using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace E7PNN.Models.Mapping
{
    public class UserFootMapping :EntityTypeConfiguration<UserFoot>
    {
        public UserFootMapping()
        {
            ToTable("UserFoot", "dbo");
            HasKey(p => p.ID);

            Property(p => p.ID).HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Act_ID).HasColumnName("Act_ID").HasColumnType("int").IsRequired();
            Property(p => p.Member_ID).HasColumnName("Member_ID").HasColumnType("int").IsRequired();



        }
    }
}