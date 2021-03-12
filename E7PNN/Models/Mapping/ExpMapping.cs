using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace E7PNN.Models.Mapping
{
    public class ExpMapping : EntityTypeConfiguration<Exp>
    {
        public ExpMapping()
        {
            ToTable("Exp", "dbo");

            HasKey(p => p.ID);

            Property(p => p.ID).HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Level).HasColumnName("Leveles").HasColumnType("nvarchar").IsRequired().HasMaxLength(400);
            Property(p => p.SumExp).HasColumnName("SumExp").HasColumnType("nvarchar").IsRequired().HasMaxLength(400);

        }
    }
}