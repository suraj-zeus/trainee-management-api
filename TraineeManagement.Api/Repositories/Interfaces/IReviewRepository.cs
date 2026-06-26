


using SharedFolder.Models;

namespace TraineeManagement.Api.Repositories;

public interface IReviewRepository
{
    public Task<List<ReviewModel>> GetReviews();

    public Task<ReviewModel> GetById(int id);

    public Task Add(ReviewModel review);
}