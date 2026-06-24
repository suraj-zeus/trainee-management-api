

using TraineeManagement.Api.Dto;

namespace TraineeManagement.Api.Services;


public interface IReviewService
{
    
    public Task<List<ReviewResponseDto>> GetAllReviews();

    public Task<ReviewResponseDto> GetReviewById(int id);

    public Task<ReviewResponseDto> AddReview(CreateReviewDto createReviewDto);
}