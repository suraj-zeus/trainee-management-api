
using TraineeManagement.Api.Dto;

namespace TraineeManagement.Api.Services;

public interface ITaskAssignmentService
{
    
    public Task<List<TaskAssignmentResponseDto>>  GetAllTaskAssignments();


    public Task<TaskAssignmentResponseDto> CreateTaskAssignment(CreateTaskAssignmentDto createTaskAssignmentDto);

    public Task<TaskAssignmentResponseDto> GetTaskAssignmentById(int id);

    public Task<TaskAssignmentResponseDto> UpdateTaskAssignmentDetails(int id, UpdateTaskAssignmentDto updateTaskAssignmentDto);

}