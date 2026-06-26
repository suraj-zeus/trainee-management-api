


using SharedFolder.Models;

namespace TraineeManagement.Api.Repositories;


public interface IProcessJobRepository
{
    public Task Add(ProcessingJobModel processingJob);

    public Task<ProcessingJobModel> GetById(int id);
}