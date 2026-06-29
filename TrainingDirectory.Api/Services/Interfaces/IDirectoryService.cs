

using TrainingDirectory.Api.Dtos;

namespace TrainingDirectory.Api.Services;


public interface IDirectoryService
{
      public TrianeeProfileRespDto GetTraineeProfileAsync(int id);
}