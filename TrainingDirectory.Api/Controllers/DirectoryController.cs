


using Microsoft.AspNetCore.Mvc;
using TrainingDirectory.Api.Services;


namespace TrainingDirectory.Api.Controllers;
 
[ApiController]
[Route("api/directory")]
public class DirectoryController : ControllerBase
{
    private readonly IDirectoryService _service;
    private ILogger<DirectoryController> _logger;
    public DirectoryController(IDirectoryService service, ILogger<DirectoryController> logger)
    {
        _service=service;
        _logger=logger;
    }
 
    [HttpGet("trainees/{id}")]
    public async Task<IActionResult> GetTraineeProfile(int id)
    {
        string requestId = HttpContext.TraceIdentifier;

        var result=await _service.GetTraineeProfileAsync(id);
        if(result==null) {
            _logger.LogWarning("Correlation Id : {requestId}. Trainee profile with Id : {id} was not found",requestId, id);
            return NotFound(new { message = $"Trainee profile with ID {id} not found." });
        }

        _logger.LogInformation("Correlation Id : {requestId}. Trainee profile with Id : {id} was fetched successfully", requestId, id);
        return Ok(result);
    }
}