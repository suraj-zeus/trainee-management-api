
using SharedFolder.Models;

namespace TraineeManagement.Api.Repositories;

public interface ISubmissionRepository
{
    public Task<List<SubmissionModel>> GetSubmissions();

    public Task<SubmissionModel> GetById(int id);

    public Task Add(SubmissionModel submission);
}