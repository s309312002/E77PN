using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using E7PNN.Models;

namespace E7PNN.Server
{
    public class UserFootDbTool:ServiceBase
    {
        public UserFootDbTool(E7pnnContext Db) : base(Db)
        {

        }
    }
}