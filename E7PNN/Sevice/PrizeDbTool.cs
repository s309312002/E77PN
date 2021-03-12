using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using E7PNN.Models;

namespace E7PNN.Server
{
    public class PrizeDbTool :ServiceBase
    {
        public PrizeDbTool(E7pnnContext Db):base(Db)
        {
        }

        public List<Prize> FindAll() 
        {
            IQueryable<Prize> tbs = this.Db.Prize;
            return tbs.ToList();
        }

        public Prize FindId(int id)
        {
            var item = this.Db.Prize.FirstOrDefault(p => p.ID == id);
            if (item == null)
                return null;
            return item;
        }

        public Prize Insert( Prize item) 
        {
            this.Db.Prize.Add(item);
            this.Db.SaveChanges();
            return item;
        }

        public Prize Update(Prize item) 
        {
            Db.Entry(item).State = System.Data.Entity.EntityState.Modified;
            this.Db.SaveChanges();
            return item;
        }
       
    }
}