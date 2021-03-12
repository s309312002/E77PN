using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace E7PNN.Models.Mapping
{
    public class JoinAccMapping : EntityTypeConfiguration<JoinAcc>
    {
        public JoinAccMapping()
        {
            ToTable(" JoinAcc", "dbo");
            HasKey(p => p.ID);

            Property(p => p.ID).HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Act_ID).HasColumnName("Act_ID").HasColumnType("int").IsRequired();
            Property(p => p.Member_ID).HasColumnName("Member_ID").HasColumnType("int").IsRequired();
            Property(p => p.UpdateTime).HasColumnName("UpdateTime").HasColumnType("DateTime").IsRequired();
            Property(p => p.JoinStatus).HasColumnName("JoinStatus").HasColumnType("int").IsRequired();


        }
    }
}