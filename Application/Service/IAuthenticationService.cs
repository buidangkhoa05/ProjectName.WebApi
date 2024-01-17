using AutoAid.Domain.Common;

namespace ProjectName.Application.Service
{
    public interface IAuthenticationService : IDisposable
    {
        Task<ApiResponse<string>> GenerateAccessToken(string uid);
        Task<ApiResponse<bool>> ValidateAccessToken(string token);
    }
}
