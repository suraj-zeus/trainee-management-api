
using TraineeManagement.Api.Dto;
using TraineeManagement.Api.Models;

namespace TraineeManagement.Api.Repositories;


public interface ITaskAssignmentRepository
{
    
    public Task<List<TaskAssignmentModel>> GetTaskAssignments();
    public Task<TaskAssignmentModel> GetById(int id);

    public Task Add(TaskAssignmentModel taskAssignment);

    public Task Delete(TaskAssignmentModel taskAssignment);

    public Task<TaskAssignmentModel> UpdateTaskAssignmentById(UpdateTaskAssignmentDto updateTaskAssignmentDto, int id);
}