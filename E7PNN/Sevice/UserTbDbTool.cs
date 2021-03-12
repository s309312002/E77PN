using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using E7PNN.Models;
using E7PNN.Models.ViewModel;

namespace E7PNN.Server
{
    public class UserTbDbTool : ServiceBase
    {
        public UserTbDbTool(E7pnnContext db):base(db)
        {
        }

        public UserTb findByid(int id)
        {
            var item0 = this.Db.UserTb.FirstOrDefault(p => p.ID == id);
            return item0;
        }

        public List<UserTb> FindAll()
        {
            IQueryable<UserTb> tbs = this.Db.UserTb;

            return tbs.ToList();
        }

        public UserTb Insert(UserTb item)
        {
            Exp exp = new Exp();
            item.Status = (Models.Src.Status)1;
            item.Iden_ID = 1;
            item.CreateDate = DateTime.Now;
            this.Db.UserTb.Add(item);
            exp.Level = "1";
            exp.SumExp = "0";
            exp.User_ID = item.ID;

            this.Db.Exp.Add(exp);
            this.Db.SaveChanges();
            return item;
        }

        public UserTb Update(UserTb item)
        {
            Db.Entry(item).State = System.Data.Entity.EntityState.Modified;


            this.Db.SaveChanges();
            
           
            return item;
        }

        

        public UserTb UpForgetNumber(ForgetVm item)
        {

            var item0 = this.Db.UserTb.FirstOrDefault(p => p.ID == item.ID);
            item0.MiNember = item.Password;
            this.Db.SaveChanges();
            return item0;
        }

        public UserTb UpDatbSter(int id)
        {
            var item0 = this.Db.UserTb.FirstOrDefault(p => p.ID == id);
            if (item0 == null)
                return null;
            item0.Status = (Models.Src.Status)2;
            this.Db.SaveChanges();
            return item0;
        }

        public UserTb ChatUpdate(UpdateUserVm item)
        {
           var item0 = this.Db.UserTb.FirstOrDefault(p => p.ID == item.id);
            var Exp0 = this.Db.Exp.FirstOrDefault(p => p.User_ID == item.id);
            var Iden0 = this.Db.Iden.FirstOrDefault(p => p.ID == item0.Iden_ID);

            item0.Email = item.Email;

            item0.Name = item.Fullname;

            item0.Niname = item.NiName;

            item0.Phone = item.Phone;

            item0.Sex = (Models.Src.Sex)item.Sex;

            item0.UserText = item.Bireday;

     
         

            return item0;
        }

        public UpdateUserVm ChatUsre(UserTb item)
        {
            var item0 = new UpdateUserVm
            {
                
             Email = item.Email,

             Fullname = item.Name,

             NiName = item.Niname,

            Phone = item.Phone,

            Sex = 1,

            Bireday = item.UserText,
        };

  

            return item0;
        }



    }
}