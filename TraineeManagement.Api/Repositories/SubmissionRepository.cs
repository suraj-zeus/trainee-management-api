

using Microsoft.EntityFrameworkCore;

using TraineeManagement.Api.DatabaseContext;
using TraineeManagement.Api.Models;
using TraineeManagement.Api.Repositories;

namespace TraineeManagement.Api.Repositories;


public class SubmissionRepository : ISubmissionRepository
{

    private AppDbContext _appDbContext;

    public SubmissionRepository(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }


    public async Task<List<SubmissionModel>> GetSubmissions()
    {
        return await _appDbContext.Submissions.ToListAsync();
    }

    public async Task<SubmissionModel> GetById(int id)
    {
        SubmissionModel submission = await _appDbContext.Submissions.FindAsync(id);
        return submission;
    }


    public async Task Add(SubmissionModel submission)
    {
        await _appDbContext.Submissions.AddAsync(submission);
        await _appDbContext.SaveChangesAsync();
    }

}