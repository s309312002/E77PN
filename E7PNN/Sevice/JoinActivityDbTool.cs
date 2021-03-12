using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using E7PNN.Models;
using E7PNN.Models.ViewModel;

namespace E7PNN.Server
{
    public class JoinActivityDbTool: ServiceBase
    {
        private UserTbDbTool UserTb;
        private ActivityDbTool ActivityTb;
        private JoinAccDbTool JoinAccTb;
        public JoinActivityDbTool(E7pnnContext Db) : base(Db)
        {
              var db = new E7pnnContext();
            this.UserTb = new UserTbDbTool(db);
            this.ActivityTb = new ActivityDbTool(db);
            this.JoinAccTb = new JoinAccDbTool(db);
        }

        //public List<Activity> Find()
        //{
        //    IQueryable<Activity> tbs = this.Db.Activity;

        //    return tbs.ToList();
        //}
        public int JoinActivity(JoinActivityVm item) 
        {
            var item0 = Chart(item);
            item0.JoinStatus =1;
            var act = this.JoinAccTb.Insert(item0);

            return 0;
        }

        public JoinAcc Chart(JoinActivityVm item) 
        {
            

            var item0 = new JoinAcc
            {
                Member_ID = item.Member_ID,
                Act_ID = item.Act_ID,
                UpdateTime = DateTime.Now,
                

            };
            return item0;
        }

        public int EscActivity(int Id)
        {
            var item = Db.JoinAcc.FirstOrDefault(p => p.Member_ID == Id);
            item.JoinStatus = 2;
            Db.Entry(item).State = System.Data.Entity.EntityState.Modified;
            this.Db.SaveChanges();

            return 0;
        }

        public List<AllJoinUserVm>  GetAllJoinUser(int ActId)
        {
            var item = Db.JoinAcc.Where(p => p.Act_ID == ActId && p.JoinStatus  == 1)
                               .Join(Db.UserTb, p => p.Member_ID, p => p.ID, (p1, p2) => new { p1, p2 })
                               .OrderBy(p => p.p1.UpdateTime)
                               .Select(p => new AllJoinUserVm { Status = (int)p.p1.JoinStatus, Name = p.p2.Name , Email = p.p2.Email , Phone =p.p2.Phone }).ToList();

            return item;
        }
    }
}