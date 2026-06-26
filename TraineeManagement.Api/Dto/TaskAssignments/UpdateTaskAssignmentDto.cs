


using System.ComponentModel.DataAnnotations;
using SharedFolder.Enums;


namespace TraineeManagement.Api.Dto;

public class UpdateTaskAssignmentDto 
{

    [Required(ErrorMessage = "Status is required")]
    [EnumDataType(typeof(TaskAssignmentStatus), ErrorMessage = "Invalid Status. Allowed values are:  Assigned, InProgress, Submitted, Reviewed and Completed")]
    public string Status { get; set; }

}