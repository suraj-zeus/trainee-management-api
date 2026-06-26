
using System.Security.Claims;


using TraineeManagement.Api.Dto;

namespace TraineeManagement.Api.Services;


public interface ISubmissionFileService
{
      
    public Task<UploadSubmissionFileResponseDto> Upload(CreateSubmissionFileDto createSubmissionFileDto, int submissionId, ClaimsPrincipal claimsPrincipalUser);

     public Task<bool> DeleteFile(int id, ClaimsPrincipal claimsPrincipalUser);


    public Task<(Stream, string, string)> DownloadFile(int id, ClaimsPrincipal claimsPrincipalUser);
}