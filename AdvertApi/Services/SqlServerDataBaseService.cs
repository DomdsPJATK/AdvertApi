using AdvertApi.DTOs.Responses;

namespace AdvertApi.Services
{
    public class SqlServerDataBaseService : IDataBaseService
    {
        public ClientRegistrationResponse RegisterClient()
        {
            return new ClientRegistrationResponse();
        }
    }
}