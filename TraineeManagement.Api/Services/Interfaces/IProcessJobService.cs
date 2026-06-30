






using TraineeManagement.Api.Dto;
using SharedFolder.Models;

namespace TraineeManagement.Api.Services;


public interface IProcessJobService
{
    public Task<ProcessingJobResponseDto> AddProcessJob(ProcessingJobModel processJob);

    public Task<ProcessingJobResponseDto> GetProcessJobById(int id);

    public Task<ProcessingJobResponseDto> RetryProcessingJob(int id);

}