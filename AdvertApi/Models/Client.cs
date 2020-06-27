﻿using System.Collections.Generic;

namespace AdvertApi.Models
{
    public class Client
    {
        public int IdClient { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Login { get; set; }

        public ICollection<Campaign> Campaigns { get; set; }
    }
}