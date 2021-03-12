using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using E7PNN.Models;

namespace E7PNN.Server
{
    public class OpinionDbTool : ServiceBase
    {
        public OpinionDbTool(E7pnnContext Db):base(Db)
        {
        }

        public List<Opinion> FindAll() 
        {
            IQueryable<Opinion> tbs = this.Db.Opinion;

            return tbs.ToList();
        }

        public Opinion FindId(int id) 
        {
            var item = this.Db.Opinion.FirstOrDefault(p => p.ID == id);
            if (item == null)
                return null;
            return item;
        }

        public Opinion Insert(Opinion item) 
        {
            this.Db.Opinion.Add(item);
            this.Db.SaveChanges();
            return item;
        }

        public Opinion Update(Opinion item) 
        {
            Db.Entry(item).State = System.Data.Entity.EntityState.Modified;
            this.Db.SaveChanges();
            return item;
        }

       
    }
}