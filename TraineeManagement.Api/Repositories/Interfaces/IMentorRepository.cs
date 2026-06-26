
using TraineeManagement.Api.Dto;
using SharedFolder.Models;

namespace TraineeManagement.Api.Repositories;



public interface IMentorRepository
{
    public Task<MentorModel> GetById(int id);

    public Task<List<MentorModel>> GetMentors();

    public Task Add(MentorModel mentor);

    public Task Delete(MentorModel mentor);

    public Task<MentorModel> UpdateMentorById(UpdateMentorDto updateMentorDto, int id);
}