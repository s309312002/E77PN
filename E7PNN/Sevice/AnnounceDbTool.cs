using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using E7PNN.Models;

namespace E7PNN.Server
{
    public class AnnounceDbTool : ServiceBase
    {
        public AnnounceDbTool(E7pnnContext Db) : base(Db)
        {
        }
        public List<Announce> FindAll()
        {
            IQueryable<Announce> tbs = this.Db.Announce;
            return tbs.ToList();
        }
        public Announce FindId(int id)
        {
            var item = this.Db.Announce.FirstOrDefault(p => p.ID == id);
            if (item == null)
                return null;
            return item;
        }

        public Announce Insert(Announce item)
        {
            this.Db.Announce.Add(item);
            this.Db.SaveChanges();
            return item;
        }

        public Announce Update(Announce item)
        {
            Db.Entry(item).State = System.Data.Entity.EntityState.Modified;
            this.Db.SaveChanges();
            return item;
        }
    }
}