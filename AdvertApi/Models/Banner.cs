﻿namespace AdvertApi.Models
{
    public class Banner
    {
        public int IdAdvertisement { get; set; }
        public int Name { get; set; }
        public double Price { get; set; }
        public int IdCampaign { get; set; }
        public decimal Area { get; set; }

        public Campaign Campaign { get; set; }
    }
}