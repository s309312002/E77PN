using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace E7PNN.Models.Mapping
{
    public class OpinionMapping : EntityTypeConfiguration<Opinion>
    {
        public OpinionMapping()
        {
            ToTable("Opinion", "dbo");

            HasKey(p => p.ID);



            Property(p => p.ID).HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.OpiType).HasColumnName("OpiType").IsRequired().HasColumnType("int");
            Property(x => x.OpiText).HasColumnName("OpiText").IsOptional().HasColumnType("nvarchar").HasMaxLength(400);
            Property(x => x.FileName).HasColumnName("FileName").IsOptional().HasColumnType("nvarchar").HasMaxLength(400);
            Property(x => x.CreateTime).HasColumnName("CreateTime").IsOptional().HasColumnType("DateTime");


        }
    }
}