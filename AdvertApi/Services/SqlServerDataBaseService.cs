using AdvertApi.DTOs.Requests;
using AdvertApi.DTOs.Responses;
using AdvertApi.Models;

namespace AdvertApi.Services
{
    public class SqlServerDataBaseService : IDataBaseService
    {
        private readonly CampaignDataBaseContext _context;

        public SqlServerDataBaseService(CampaignDataBaseContext context)
        {
            _context = context;
        }

        public ClientRegistrationResponse RegisterClient(ClientRegistrationRequest request)
        {
            return new ClientRegistrationResponse();
        }

        public GetRefreshAndAccessTokenResponse GetRefreshAndAccessToken(string refreshToken)
        {
            throw new System.NotImplementedException();
        }

        public GetRefreshAndAccessTokenResponse GetUserAuthorization(AuthorizationRequest authRequest)
        {
            throw new System.NotImplementedException();
        }
        
    }
}