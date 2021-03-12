using E7PNN.Models;
using E7PNN.Server;
using E7PNN.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E7PNN.Sevice
{
    public class EditAnnounceDbTool : ServiceBase
    {
        private UserTbDbTool UserTb;
        private AnnounceDbTool AnnounceTb;
        private UpdateJpg updateJpg;


        public EditAnnounceDbTool(E7pnnContext Db):base(Db)
        {
            var db = new E7pnnContext();
            this.UserTb = new UserTbDbTool(db);
            this.AnnounceTb = new AnnounceDbTool(db);
            this.updateJpg = new UpdateJpg();

        }


        public Announce EditAnnounce(EditAnnounceVm item, int id) 
        {
         var User = Db.UserTb.FirstOrDefault(p => p.ID == id);


            if (item != null)
            {
                for (int x = 0; x < item.PicFileName.Count; x++)

                    if (item.PicFileName[x] != null)
                    {
                        this.updateJpg.UpJpg(item.PicFileName[x], x);
                    }

         

                var item0 = ChatEdit(item);
                item0.Member_ID = id;
                item0.AnnUser = User.Name;
                item0.Pic1 = "1";
                item0.Pic2 = "1";
                item0.Pic3 = "1";
                item0.Pic4 = "1";
                item0.Pic5 = "1";
                item0.AnnLong = "1";
                item0.AnnLat = "1";

                var sur = this.AnnounceTb.Insert(item0);
                return sur;
            }
            return null;
        }
        public Announce CreateAnn(EditAnnounceVm item)
        {
            var item0 = ChatEdit(item);
            this.AnnounceTb.Insert(item0);

            return item0;
        }
        public Announce ChatEdit(EditAnnounceVm item) 
        {

            var item0 = new Announce
            {
                AnnLat = item.AnnLat,

                AnnTime = DateTime.Now,

                AnnType = (Models.Src.AnnType)item.AnnType,

                AnnText = item.AnnText,

                AnnLong = item .AnnLong,

                Status = (Models.Src.Status)1,

                AnnSite = item.AnnSite,

                

            };

            return item0;
        }

        public EditActivityVm UserTbx(int Id)
        {
            var item1 = this.Db.UserTb.FirstOrDefault(p => p.ID == Id);
            var item0 = new EditActivityVm
            {
                Email = item1.Email,

                Number =item1.Phone,
            };

            return item0;
        }

    }
}