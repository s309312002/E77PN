using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using E7PNN.Models;

namespace E7PNN.Server
{
    public class JoinAccDbTool : ServiceBase
    {
        public JoinAccDbTool(E7pnnContext Db ):base (Db)
        {

        }

        public List<JoinAcc> FindAll()
        {
            IQueryable<JoinAcc> tbs = this.Db.JoinAcc;
            return tbs.ToList();
        }

        public JoinAcc Insert(JoinAcc item)
        {
            this.Db.JoinAcc.Add(item);
            this.Db.SaveChanges();
            return item;
        }

        public JoinAcc Update(JoinAcc item)
        {
            Db.Entry(item).State = System.Data.Entity.EntityState.Modified;
            this.Db.SaveChanges();
            return item;
        }
    }
}