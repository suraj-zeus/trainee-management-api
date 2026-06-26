using TrainingDirectory.Api.Dtos;

namespace TrainingDirectory.Api.Services;


public class DirectoryService : IDirectoryService
{
    public async Task<TrianeeProfileRespDto> GetTraineeProfileAsync(int id)
    {
        TrianeeProfileRespDto trainee = new ()
        {
            Id = id,
            FirstName = "suraj",
            LastName = "prajapati",
            Email = "suraj@gmail.com",
            TechStack = "java",
            Status = "Active",
            CreatedDate = DateTime.UtcNow,
            UpdatedDate = DateTime.UtcNow
        };

        return trainee;
    }
}