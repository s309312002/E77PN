using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using E7PNN.Models;

namespace E7PNN.Server
{
    public class ExpDbTool : ServiceBase
    {
        public ExpDbTool(E7pnnContext Db):base(Db)
        {
        }

        public List<Exp> FindAll()
        {
            IQueryable<Exp> tbs = this.Db.Exp;
            return tbs.ToList();
        }
        public Exp FindId(int id)
        {
            var item = this.Db.Exp.FirstOrDefault(p => p.ID == id);
            if (item == null)
                return null;
            return item;
        }

        public Exp Insert(Exp item)
        {
            this.Db.Exp.Add(item);
            this.Db.SaveChanges();
            return item;
        }

        public Exp Update(Exp item)
        {
            Db.Entry(item).State = System.Data.Entity.EntityState.Modified;
            this.Db.SaveChanges();
            return item;
        }
    }
}