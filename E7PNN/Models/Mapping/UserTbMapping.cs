using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;


namespace E7PNN.Models
{
    public class UserTbMapping : EntityTypeConfiguration<UserTb>
    {
        public UserTbMapping() 
        {
            ToTable("UserTb", "dbo");
            HasKey(p => p.ID);

            Property(p => p.ID).HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.UserNember).HasColumnName("UserNember").IsOptional().HasColumnType("nvarchar").HasMaxLength(300);
            Property(x => x.MiNember).HasColumnName("MiNember").IsRequired().HasColumnType("nvarchar").HasMaxLength(300);
            Property(x => x.Status).HasColumnName("Status").IsRequired().HasColumnType("int");
            Property(x => x.Email).HasColumnName("Email").IsRequired().HasColumnType("nvarchar").HasMaxLength(300);
            Property(x => x.Points).HasColumnName("Points").IsOptional().HasColumnType("int");
            Property(x => x.Name).HasColumnName("Name").IsOptional().HasColumnType("nvarchar").HasMaxLength(300);
            Property(x => x.Phone).HasColumnName("Phone").IsOptional().HasColumnType("nvarchar").HasMaxLength(300);
            Property(x => x.UserText).HasColumnName("UserText").IsOptional().HasColumnType("nvarchar").HasMaxLength(300);
            Property(x => x.Sex).HasColumnName("Sex").IsOptional().HasColumnType("int");
            Property(x => x.Niname).HasColumnName("Niname").IsOptional().HasColumnType("nvarchar").HasMaxLength(300);
            Property(x => x.CreateDate).HasColumnName("DateTime").IsRequired().HasColumnType("DateTime");
           






        }
    }
}