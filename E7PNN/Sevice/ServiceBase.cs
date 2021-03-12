using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using E7PNN.Models;

namespace E7PNN.Server
{
    public class ServiceBase
    {
        protected E7pnnContext Db;

        public ServiceBase(E7pnnContext Db)
        {
            this.Db = Db;
        }

        public void dispose() 
        {
            this.Db.Dispose();
        }

    }
}