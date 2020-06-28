using AdvertApi.Configurations;
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

            modelBuilder.ApplyConfiguration(new ClientEfConfiguration());
            modelBuilder.ApplyConfiguration(new BuildingEfConfiguration());
            modelBuilder.ApplyConfiguration(new BannerEfConfiguration());
            modelBuilder.ApplyConfiguration(new CampaignEfConfiguration());
        }
    }
}