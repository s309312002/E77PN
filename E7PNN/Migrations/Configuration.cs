namespace E7PNN.Migrations
{
    using E7PNN.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<E7PNN.Models.E7pnnContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(E7PNN.Models.E7pnnContext context)
        {
            context.UserTb.AddOrUpdate(new UserTb()
            {
                UserNember = "root",
                MiNember = "root",
                Iden_ID = 1,
                Status = (Models.Src.Status)1,
                Email = "root@gm.fgu",
                Points = 0,
                Name = "管理者",
                Phone = "09888888888",
                Sex = (Models.Src.Sex)1,
                CreateDate = DateTime.Now
            }); ;
            context.Exp.AddOrUpdate(new Exp
            {
                Level = "1",
                SumExp = "0"
            });
            context.Iden.AddOrUpdate(new Iden()
            {
                ID = 1,
                IdenName = "一般"

            }, new Iden()
            {
                ID = 2,
                IdenName = "企業"
            }, new Iden()
            {
                ID = 3,
                IdenName = "管理者"
            }, new Iden()
            {
                ID = 4,
                IdenName = "開發人員"
            });
        }
    }
}
