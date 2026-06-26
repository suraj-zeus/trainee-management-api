using Microsoft.EntityFrameworkCore;

using TraineeManagement.Api.DatabaseContext;
using SharedFolder.Models;

namespace TraineeManagement.Api.Repositories;

public class ProcessingJobRepository : IProcessJobRepository
{
    private AppDbContext _appDbContext;

    public ProcessingJobRepository(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task Add(ProcessingJobModel processingJob)
    {
        await _appDbContext.ProcessingJobs.AddAsync(processingJob);
        await _appDbContext.SaveChangesAsync();
    }

    public async Task<ProcessingJobModel> GetById(int id)
    {
        return await _appDbContext.ProcessingJobs.FindAsync(id);
    }

}