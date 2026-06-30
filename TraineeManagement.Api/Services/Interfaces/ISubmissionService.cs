using System.Security.Claims;


using TraineeManagement.Api.Dto;
using SharedFolder.Models;

namespace TraineeManagement.Api.Services;

public interface ISubmissionService
{

    public Task<List<SubmissionResponseDto>> GetAllSubmissions();

    public Task<SubmissionResponseDto> GetSubmissionById(int id);

    public Task<SubmissionSummaryResponseDto> GetSubmissionSummaryById(int id);

    public Task<SubmissionResponseDto> AddSubmission(CreateSubmissionDto createSubmissionDto);


}