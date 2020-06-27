using Microsoft.EntityFrameworkCore;

namespace AdvertApi.Models
{
    public class CampaignDataBaseContext : DbContext
    {
        protected CampaignDataBaseContext()
        {
        }

        public CampaignDataBaseContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}