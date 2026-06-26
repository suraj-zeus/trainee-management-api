


using TraineeManagement.Api.ValidationAttributes;
using System.ComponentModel.DataAnnotations;


namespace TraineeManagement.Api.Dto;



public class CreateSubmissionFileDto
{
    public IFormFile? formFile {get; set; }
}