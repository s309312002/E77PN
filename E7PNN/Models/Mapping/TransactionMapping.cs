using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;


namespace E7PNN.Models.Mapping
{
    public class TransactionMapping:EntityTypeConfiguration<Transaction>
    {
        public TransactionMapping()
        {
            ToTable("Transaction", "dbo");
            HasKey(p => p.ID);


            Property(p => p.ID).HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.BuyTime).HasColumnName("BuyTime").IsRequired().HasColumnType("DateTime");
            Property(x => x.Amount).HasColumnName("Amount").IsRequired().HasColumnType("int");
            Property(x => x.ExchangeTime).HasColumnName("ExchangeTime").IsRequired().HasColumnType("DateTime");
            Property(x => x.EndchangeTime).HasColumnName("EndchangeTime").IsRequired().HasColumnType("DateTime");

        }
    }
}