using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace E7PNN.Models.Mapping
{
    public class IdenMapping : EntityTypeConfiguration<Iden>
    {
        public IdenMapping()
        {
            ToTable("Iden", "dbo");

            HasKey(p => p.ID);

            Property(p => p.ID).HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.IdenName).HasColumnName("IdenName").IsOptional().HasColumnType("nvarchar").HasMaxLength(400);


        }
    }
}