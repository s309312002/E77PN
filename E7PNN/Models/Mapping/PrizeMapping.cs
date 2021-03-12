using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace E7PNN.Models.Mapping
{
    public class PrizeMapping : EntityTypeConfiguration<Prize>
    {
        public PrizeMapping()
        {
            ToTable("Prize", "dbo");

            HasKey(p => p.ID);

            Property(p => p.ID).HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.PrizeName).HasColumnName("PrizeName").IsRequired().HasColumnType("nvarchar").HasMaxLength(300);
            Property(x => x.Stock).HasColumnName("Stock").IsRequired().HasColumnType("int");
            Property(x => x.UpdateTime).HasColumnName("UpdateTime").IsRequired().HasColumnType("DateTime");


        }

    }
}