using AdvertApi.DTOs.Responses;

namespace AdvertApi.Services
{
    public interface IDataBaseService
    {
        public ClientRegistrationResponse RegisterClient();
    }
}