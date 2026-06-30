




using TraineeManagement.Api.Dto;
using SharedFolder.Models;
using SharedFolder.Messaging;
using SharedFolder.Enums;
using TraineeManagement.Api.Repositories;

namespace TraineeManagement.Api.Services;


public class ProcessJobService : IProcessJobService
{
    private IProcessJobRepository _processJobRepository;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private IRabbitMqService _rabbitMqService;

    private ILogger<ProcessJobService> _logger;


    public ProcessJobService(
        IProcessJobRepository processJobRepository, 
        IHttpContextAccessor httpContextAccessor, 
        IRabbitMqService rabbitMqService,
        ILogger<ProcessJobService> logger
    )
    {
        _processJobRepository = processJobRepository;
        _httpContextAccessor = httpContextAccessor;
        _rabbitMqService = rabbitMqService;
        _logger = logger;
    }

    public async Task<ProcessingJobResponseDto> AddProcessJob(ProcessingJobModel processJob)
    {
        await _processJobRepository.Add(processJob);

        return MapProcessingJobToProcessingResponseDto(processJob);
    }

    public async Task<ProcessingJobResponseDto> GetProcessJobById(int id)
    {
        ProcessingJobModel processingJob = await _processJobRepository.GetById(id);

        if (processingJob == null)
        {
            throw new KeyNotFoundException($"Process Job record with id : {id} was not found");
        }

        return MapProcessingJobToProcessingResponseDto(processingJob);
    }



    public async Task<ProcessingJobResponseDto> RetryProcessingJob(int id)
    {
        string requestId = _httpContextAccessor.HttpContext.TraceIdentifier;
        var job = await _processJobRepository.GetById(id);

        if (job == null)
        {
            _logger.LogInformation($"RequestId : [{requestId}]. No job found with Id : {id}");
            throw new KeyNotFoundException($"No job found with Id : {id}");
        }

        if (job.Status == ProcessingJobStatus.Completed.ToString())
        {
            _logger.LogInformation($"RequestId : [{requestId}]. Job with job id : {id} already completed");
            throw new KeyNotFoundException($"RequestId : [{requestId}]. Job with job id : {id} already completed");
        }

        

        // create new message with new correlation and message id
        string newMessageId = Guid.NewGuid().ToString();
        string prevCorrelationId = job.CorrelationId;
        string prevMessageId = job.MessageId;

        var message = new SubmissionProcessingRequest()
        {
            MessageId = newMessageId,
            CorrelationId = requestId,
            SubmissionId = job.SubmissionId,
            FileId = job.FileId,
            RequestedAt = DateTime.Now,
            ContractVersion = 1
        };

        string prevStatus = job.Status;

        try
        {
            // update status, new correlation id and new MessageId
            job.Status = ProcessingJobStatus.Queued.ToString();
            job.CorrelationId = requestId;
            job.MessageId = newMessageId;

            await _rabbitMqService.PublishAsync(message);
            await _processJobRepository.UpdateProcessingJob();

            return MapProcessingJobToProcessingResponseDto(job);
        }
        catch (Exception ex)
        {
            // roll back to previous state
            job.Status = prevStatus;
            job.MessageId = prevMessageId;
            job.CorrelationId = prevCorrelationId;

            await _processJobRepository.UpdateProcessingJob();
            _logger.LogError(ex, $"Error while retrying processing job");
            throw;
        }
    }

    private ProcessingJobResponseDto MapProcessingJobToProcessingResponseDto(ProcessingJobModel processingJob)
    {
        ProcessingJobResponseDto processingJobResponseDto = new()
        {
            Id = processingJob.Id,
            MessageId = processingJob.MessageId,
            CorrelationId = processingJob.CorrelationId,
            SubmissionId = processingJob.SubmissionId,
            FileId = processingJob.FileId,
            Status = processingJob.Status,
            Attempts = processingJob.Attempts,
            ErrorSummary = processingJob.ErrorSummary,
            StartedDate = processingJob.StartedDate,
            CompletedDate = processingJob.CompletedDate
        };

        return processingJobResponseDto;
    }

}