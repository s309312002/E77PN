using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using E7PNN.Models;
using E7PNN.Models.ViewModel;

namespace E7PNN.Server
{
    public class CreateEventDbTool : ServiceBase
    {
        private UserTbDbTool UserTb;
        private ActivityDbTool ActivityTb;
        public CreateEventDbTool(E7pnnContext Db) : base(Db)
        {
            var db = new E7pnnContext();
            this.UserTb = new UserTbDbTool(db);
            this.ActivityTb = new ActivityDbTool(db);
        }

        public Activity FstrEdit(EditActivityVm item) 
        {
            var item0 = Conversion(item);
            item0.ActClass = (Models.Src.ActClass)3;
            this.ActivityTb.Insert(item0);

            return item0;
        }

        public Activity FixedEdit(EditActivityVm item)
        {
            var item0 = Conversion(item);
            
            this.ActivityTb.Insert(item0);

            return item0;
        }

        public Activity FreeEdit(EditActivityVm item)
        {
            var item0 = Conversion(item);
            item0.ActClass = (Models.Src.ActClass)1;
            this.ActivityTb.Insert(item0);

            return item0;
        }

        public Activity TeamEdit(EditActivityVm item)
        {
            var item0 = Conversion(item);
            item0.ActClass = (Models.Src.ActClass)2;
            this.ActivityTb.Insert(item0);

            return item0;
        }


        public EditActivityVm UserDatex(int id) 
        {
            var item1 = this.Db.UserTb.FirstOrDefault(p => p.ID ==id);

            var Item0 = new EditActivityVm
            {
                Email = item1.Email,

                Number = item1.Phone,
            };

            return Item0;
        }

        public Activity Conversion(EditActivityVm item) 
        {

            var item0 = this.Db.UserTb.FirstOrDefault(p => p.Phone == item.Number &&  p.Email == item.Email );

            var Acitem = new Activity
            {
                ActName = item.ActName,
                ActTime = item.ActTime,
                ActSite = item.ActSite,
                ActType = (Models.Src.AnnType)item.ActType,
                ActUser = item0.Name,
                Member_ID = item0.ID,
                SumPeople = item.SumPeople,
                ActStatus = 0,
                ActText = item.Text,
                StatTime = item.StarTime,
                EndTime = item.EndTime,
                ActLong = "123",
                ActLat = "000",
                ActClass = (Models.Src.ActClass)item.ActClass,
            };

            return Acitem;
        }
    }
}