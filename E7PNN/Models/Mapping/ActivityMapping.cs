using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace E7PNN.Models.Mapping
{
    public class ActivityMapping :EntityTypeConfiguration<Activity>
    {
        public ActivityMapping()
        {
            ToTable("Activity", "dbo");

            HasKey(p => p.ID);

        

            Property(p => p.ID).HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.ActName).HasColumnName("ActName").HasColumnType("nvarchar").IsRequired().HasMaxLength(400);
            Property(p => p.ActTime).HasColumnName("ActTime").HasColumnType("DateTime").IsRequired();
            Property(p => p.ActSite).HasColumnName("ActSite").HasColumnType("nvarchar").IsRequired().HasMaxLength(400);
            Property(p => p.ActType).HasColumnName("ActType").HasColumnType("int").IsRequired();
            Property(p => p.ActUser).HasColumnName("ActUser").HasColumnType("nvarchar").IsRequired().HasMaxLength(400);
            Property(p => p.SumPeople).HasColumnName("SumPeople").HasColumnType("nvarchar").IsRequired().HasMaxLength(400);
            Property(p => p.ActText).HasColumnName("ActText").HasColumnType("nvarchar").IsRequired().HasMaxLength(400);
            Property(p => p.ActClass).HasColumnName("ActClass").HasColumnType("int").IsRequired();
            Property(p => p.ActStatus).HasColumnName("ActStatus").HasColumnType("int").IsRequired();
            Property(p => p.ActLong).HasColumnName("ActLong").HasColumnType("nvarchar").IsRequired().HasMaxLength(400);
            Property(p => p.Cause).HasColumnName("Cause").HasColumnType("nvarchar").IsOptional().HasMaxLength(400);
            Property(p => p.ActLat).HasColumnName("ActLat").HasColumnType("nvarchar").IsRequired().HasMaxLength(400);
            Property(p => p.StatTime).HasColumnName("StatTime").HasColumnType("DateTime").IsRequired();
            Property(p => p.EndTime).HasColumnName("EndTime").HasColumnType("DateTime").IsRequired();
        }
    }
}