using System.Collections.Generic;
using AdvertApi.Models;

namespace AdvertApi.DTOs.Responses
{
    public class GetCapmpaignsResponse
    {
        public List<Campaign> Campaigns { get; set; }
        public Client Client { get; set; }
        public List<Banner> Banners { get; set; }
    }
}