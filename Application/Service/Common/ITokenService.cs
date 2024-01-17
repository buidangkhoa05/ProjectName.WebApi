using AutoAid.Domain.Common;
using System.Security.Claims;

namespace ProjectName.Application.Service.Common
{
    public interface ITokenService
    {
        string Encode(GenerateTokenReq data);
        IEnumerable<Claim> Decode(string token);
    }
}
