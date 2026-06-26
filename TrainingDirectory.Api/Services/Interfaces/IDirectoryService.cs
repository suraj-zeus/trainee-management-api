

using TrainingDirectory.Api.Dtos;

namespace TrainingDirectory.Api.Services;


public interface IDirectoryService
{
      public Task<TrianeeProfileRespDto> GetTraineeProfileAsync(int id);
}