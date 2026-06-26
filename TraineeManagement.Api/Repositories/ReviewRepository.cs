
using Microsoft.EntityFrameworkCore;



using SharedFolder.DatabaseContext;
using SharedFolder.Models;
using TraineeManagement.Api.Repositories;

namespace TraineeManagement.Api.Repositories;

public class ReviewRepository : IReviewRepository
{
    
    private AppDbContext _appDbContext;

    public ReviewRepository(AppDbContext appDbContext)
    {
       _appDbContext = appDbContext;
    }


     public async Task<List<ReviewModel>> GetReviews()
    {
        return await _appDbContext.Reviews.ToListAsync();
    }

    public async Task<ReviewModel> GetById(int id)
    {
        ReviewModel review = await _appDbContext.Reviews.FindAsync(id);
        return review;
    }

    public async Task Add(ReviewModel review)
    {
        await _appDbContext.Reviews.AddAsync(review);
        await _appDbContext.SaveChangesAsync();
    }

}