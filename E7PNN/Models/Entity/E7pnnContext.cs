using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using E7PNN.Models.Mapping;

namespace E7PNN.Models
{
    public partial class E7pnnContext : DbContext
    {
        public E7pnnContext()
            : base("name=E7pnn")
        {
        }
        public E7pnnContext(string connStr) : base(connStr)
        {
        }


        public virtual DbSet<Activity> Activity { get; set; }
        public virtual DbSet<Announce> Announce { get; set; }
        public virtual DbSet<Exp> Exp { get; set; }
        public virtual DbSet<Iden> Iden { get; set; }
        public virtual DbSet<Like> Like { get; set; }
        public virtual DbSet<Opinion> Opinion { get; set; }
        public virtual DbSet<Prize> Prize { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<UserFoot> UserFoot { get; set; }
        public virtual DbSet<UserTb> UserTb { get; set; }
        public virtual DbSet<JoinAcc> JoinAcc { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserTbMapping());
            modelBuilder.Configurations.Add(new UserFootMapping());
            modelBuilder.Configurations.Add(new TransactionMapping());
            modelBuilder.Configurations.Add(new PrizeMapping());
            modelBuilder.Configurations.Add(new OpinionMapping());
            modelBuilder.Configurations.Add(new LikeMapping());
            modelBuilder.Configurations.Add(new IdenMapping());
            modelBuilder.Configurations.Add(new ExpMapping());
            modelBuilder.Configurations.Add(new AnnounceMapping());
            modelBuilder.Configurations.Add(new ActivityMapping());
        }
    }
}
