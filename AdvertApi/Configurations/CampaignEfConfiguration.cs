﻿using AdvertApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdvertApi.Configurations
{
    public class CampaignEfConfiguration : IEntityTypeConfiguration<Campaign>
    {
        public void Configure(EntityTypeBuilder<Campaign> builder)
        {
            builder.HasKey(p => p.IdCampaign);
            builder.Property(p => p.IdCampaign).ValueGeneratedOnAdd();

            builder.Property(p => p.StartDate).IsRequired();
            builder.Property(p => p.EndDate).IsRequired();
            builder.Property(p => p.PricePerSquareMarker).HasPrecision(6, 2).IsRequired();

            builder.HasOne(p => p.Client).WithMany(p => p.Campaigns).HasForeignKey(p => p.IdClient);
            builder.HasOne(p => p.FromBuilding).WithMany(p => p.Campaigns).HasForeignKey(p => p.FromIdBuilding);
            builder.HasOne(p => p.FromBuilding).WithMany(p => p.Campaigns).HasForeignKey(p => p.ToIdBuilding);
        }
    }
}