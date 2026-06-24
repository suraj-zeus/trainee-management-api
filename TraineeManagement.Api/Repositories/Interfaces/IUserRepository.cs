



using TraineeManagement.Api.Models;

namespace TraineeManagement.Api.Repositories;




public interface IUserRepository
{

    public Task<UserModel> GetByUsername(string username);

}