using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using E7PNN.Models;

namespace E7PNN.Server
{
    public class TransactionDbTool:ServiceBase
    {
        public TransactionDbTool(E7pnnContext Db):base(Db)
        {

        }

        public Transaction FindId(int id) 
        {
            var item = this.Db.Transactions.FirstOrDefault(p => p.ID == id);

            if (item == null)
                return null;

            return item;
        }

        public List<Transaction> FindAll() 
        {
            IQueryable<Transaction> tbs = this.Db.Transactions;
            return tbs.ToList();
        }

        public Transaction Insert(Transaction item) 
        {
            this.Db.Transactions.Add(item); 
            this.Db.SaveChanges();
            return item;
        }

        public Transaction Update(Transaction item) 
        {
            Db.Entry(item).State = System.Data.Entity.EntityState.Modified;
            this.Db.SaveChanges();
            return item;
        }

    }
}