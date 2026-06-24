

using TraineeManagement.Api.Messaging;

namespace TraineeManagement.Api.Services;


public interface IRabbitMqService
{
        public Task PublishAsync(SubmissionProcessingRequest submissionProcessingRequest);

}