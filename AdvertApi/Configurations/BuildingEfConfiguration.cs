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
            builder.Property(p => p.Street).HasMaxLength(100);
            builder.Property(p => p.City).HasMaxLength(100);
        }
    }
}