using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace E7PNN.Models.Mapping
{
    public class AnnounceMapping : EntityTypeConfiguration<Announce>
    {
        public AnnounceMapping()
        {
            ToTable("Announce", "dbo");

            HasKey(p => p.ID);


            Property(p => p.ID).HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.AnnTime).HasColumnName("AnnTime").HasColumnType("DateTime").IsRequired();
            Property(p => p.AnnSite).HasColumnName("AnnSite").HasColumnType("nvarchar").IsRequired().HasMaxLength(400);
            Property(p => p.AnnType).HasColumnName("AnnType").HasColumnType("int").IsRequired();
            Property(p => p.AnnUser).HasColumnName("AnnUser").HasColumnType("nvarchar").IsRequired().HasMaxLength(400);
            Property(p => p.AnnText).HasColumnName("AnnText").HasColumnType("nvarchar").IsRequired().HasMaxLength(400);
            Property(p => p.Pic1).HasColumnName("Pic1").HasColumnType("nvarchar").IsRequired().HasMaxLength(400);
            Property(p => p.Pic2).HasColumnName("Pic2").HasColumnType("nvarchar").IsRequired().HasMaxLength(400);
            Property(p => p.Pic3).HasColumnName("Pic3").HasColumnType("nvarchar").IsRequired().HasMaxLength(400);
            Property(p => p.Pic4).HasColumnName("Pic4").HasColumnType("nvarchar").IsRequired().HasMaxLength(400);
            Property(p => p.Pic5).HasColumnName("Pic5").HasColumnType("nvarchar").IsRequired().HasMaxLength(400);
            Property(p => p.Status).HasColumnName("Status").HasColumnType("int").IsRequired();
            Property(p => p.AnnLong).HasColumnName("AnnLong").HasColumnType("nvarchar").IsRequired().HasMaxLength(400);
            Property(p => p.Cause).HasColumnName("Cause").HasColumnType("nvarchar").IsOptional().HasMaxLength(400);
            Property(p => p.AnnLat).HasColumnName("AnnLat").HasColumnType("nvarchar").IsRequired().HasMaxLength(400);


        }
    }
}