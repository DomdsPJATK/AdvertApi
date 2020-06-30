using AdvertApi.DTOs.Requests;
using AdvertApi.DTOs.Responses;

namespace AdvertApi.Services
{
    public interface IDataBaseService
    {
        public ClientRegistrationResponse RegisterClient(ClientRegistrationRequest request);
        public GetRefreshAndAccessTokenResponse GetRefreshAndAccessToken(string refreshToken);
        public GetRefreshAndAccessTokenResponse GetUserAuthorization(AuthorizationRequest authRequest);
    }
}