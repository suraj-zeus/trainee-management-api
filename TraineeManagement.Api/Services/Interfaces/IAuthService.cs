


using TraineeManagement.Api.Dto;

namespace TraineeManagement.Api.Services;


public interface IAuthService
{
    public Task<UserLoginResponseDto> LoginService(UserLoginRequestDto userLoginRequestDto);

}