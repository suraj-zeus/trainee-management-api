

using SharedFolder.Models;

namespace TraineeManagement.Api.Repositories;



public interface ISubmissionFileRepository
{
    public Task Add(SubmissionFileModel submissionFile);

    public Task<SubmissionFileModel> FindById(int id);

    public Task Delete(SubmissionFileModel submissionFile);

    public Task<SubmissionFileModel> FindByChecksum(string checkSum);
}