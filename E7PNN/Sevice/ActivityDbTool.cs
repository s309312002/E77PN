using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using E7PNN.Models;
using E7PNN.Models.ViewModel;

namespace E7PNN.Server
{
    public class ActivityDbTool : ServiceBase
    {
        public ActivityDbTool(E7pnnContext Db):base(Db)
        {

        }
        public List<Activity> FindAll()
        {
            IQueryable<Activity> tbs = this.Db.Activity;
            return tbs.ToList();
        }

        public List<Activity> FindNew()
        {
            IQueryable<Activity> tbs = this.Db.Activity;
            var item = tbs.OrderBy(p => p.ActTime).Take(3);
                                
            return item.ToList();
        }
        public Activity FindId(int id)
        {
            var item = this.Db.Activity.FirstOrDefault(p => p.ID == id);
            if (item == null)
                return null;
            return item;
        }

        public List<ActivityVm> Count()
        {
            var result = this.Db.Activity.GroupBy(x => x.ActType, (ActType, ID) => new ActivityVm
            {
                Type = (int)ActType,
                Count = ID.Count(),
            });

            return result.ToList();
        }

        
        public List<ActivityVm> TeCount()
        {
            var result = this.Db.Activity.GroupBy(x => x.ActType, (ActSite, ID) => new ActivityVm
            {
                Count = ID.Count(),
            });

            return result.ToList();
        }
        
        public Activity Insert(Activity item)
        {
            this.Db.Activity.Add(item);
            this.Db.SaveChanges();
            return item;
        }

        public Activity Update(Activity item)
        {
            Db.Entry(item).State = System.Data.Entity.EntityState.Modified;
            this.Db.SaveChanges();
            return item;
        }

        public List<NewestActivityVm> UnsolvedCount()
        {
            var result = this.Db.Activity.GroupBy(x => x.ActType, (ActType, ID) => new NewestActivityVm
            {

                UnsolvedCount = ID.Count(),
                SolvedCount = ID.Count(),
                PastActivityCount = ID.Count(),
            });

            return result.ToList();
        }



    }
}