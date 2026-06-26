using SubmissionProcessor.Worker.Dtos;
using static System.Net.HttpStatusCode;

using System.Net;          
using System.Net.Http.Json;

namespace SubmissionProcessor.Worker.ServiceClients;


public class TrainingDirectoryServiceClient
{
    private readonly HttpClient _httpClient;
    private readonly ILogger<TrainingDirectoryServiceClient> _logger;
    

    public TrainingDirectoryServiceClient(
        HttpClient httpClient,
        ILogger<TrainingDirectoryServiceClient> logger
    )
    {
        _logger = logger;
        _httpClient = httpClient;
    }



    public async Task<TraineeProfileDto?> GetTraineeByIdAsync(int id, string? correlationId, CancellationToken cancellationToken)
    {
        try
        {

            var request = new HttpRequestMessage(HttpMethod.Get, $"api/directory/trainees/{id}");

            if (string.IsNullOrEmpty(correlationId))
            {
                correlationId = Guid.NewGuid().ToString();
            }

            request.Headers.Add("X-Correlation-ID", correlationId);


            using var response = await _httpClient.SendAsync(request, cancellationToken);

            response.EnsureSuccessStatusCode();

            var trainee = await response.Content.ReadFromJsonAsync<TraineeProfileDto>(cancellationToken: cancellationToken);
            return trainee;

            // var trainee = await _httpClient.GetFromJsonAsync<TraineeProfileDto>($"api/directory/trainees/{id}", cancellationToken);
            // return trainee;
        }
        catch (HttpRequestException ex) when (ex.StatusCode ==  HttpStatusCode.NotFound)
        {
            _logger.LogWarning("Trainee with ID {Id} was not found.", id);
            throw;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error fetching trainee with ID {Id}.", id);
            throw;
        }

    }
}