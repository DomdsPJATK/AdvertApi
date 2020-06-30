using AdvertApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdvertApi.Configurations
{
    public class BuildingEfConfiguration : IEntityTypeConfiguration<Building>
    {
        public void Configure(EntityTypeBuilder<Building> builder)
        {
            builder.HasKey(p => p.IdBuilding);
            builder.Property(p => p.Street).HasMaxLength(100).IsRequired();
            builder.Property(p => p.StreetNumber).IsRequired();
            builder.Property(p => p.City).HasMaxLength(100).IsRequired();
            builder.Property(p => p.Height).HasPrecision(6, 2);

        }
    }
}