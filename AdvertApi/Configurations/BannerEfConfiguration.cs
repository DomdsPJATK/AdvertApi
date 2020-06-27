using AdvertApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdvertApi.Configurations
{
    public class BannerEfConfiguration : IEntityTypeConfiguration<Banner>
    {
        public void Configure(EntityTypeBuilder<Banner> builder)
        {
            builder.HasKey(p => p.IdAdvertisement);
            builder.Property(p => p.IdAdvertisement).ValueGeneratedOnAdd();

            builder.HasOne(p => p.Campaign).WithMany(p => p.Banners).HasForeignKey(p => p.IdCampaign);
        }
    }
}