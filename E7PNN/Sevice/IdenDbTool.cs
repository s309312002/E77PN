using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using E7PNN.Models;

namespace E7PNN.Server
{
    public class IdenDbTool:ServiceBase
    {
        public IdenDbTool(E7pnnContext Db):base(Db)
        {
        }
        public List<Iden> FindAll() 
        {
            IQueryable<Iden> tbs = this.Db.Iden;
            return tbs.ToList();
        }
        public Iden FindId(int id) 
        {
            var item = this.Db.Iden.FirstOrDefault(p => p.ID == id);
            if (item == null)
                return null;
            return item;
        }

        public Iden Insert(Iden item)
        {
            this.Db.Iden.Add(item);
            this.Db.SaveChanges();
            return item;
        }

        public Iden Update(Iden item)
        {
            Db.Entry(item).State = System.Data.Entity.EntityState.Modified;
            this.Db.SaveChanges();
            return item;
        }
    }
}