using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using E7PNN.Models;
using E7PNN.Models.Auth;
using E7PNN.Models.ViewModel;
using E7PNN.Server;
using E7PNN.Sevice;

namespace E7PNN.Controllers
{
    public class MemberController : Controller
    {

        private UserTbDbTool Userver;
        private ActivityDbTool Actsever;
        private UpdateJpg UpdateJpg;
        public MemberController()
        {
            var Db = new E7pnnContext();
            this.Userver = new UserTbDbTool(Db);
            this.Actsever = new ActivityDbTool(Db);
            this.UpdateJpg = new UpdateJpg();
        }
        [UserAuthFilter]
        public ActionResult Member()
        {
            return View();
        }
        [UserAuthFilter]
        public ActionResult Sidebar()
        {


            return PartialView();
        }
        [UserAuthFilter]
        public ActionResult MemberData()
        {
            //var data= this.Userver.FindAll()
            //  var id = 1;
            var id = UserVm.LoginUser.UserId;
            if (id == 0)
                id = 1;
            var item = this.Userver.findByid(id);

            return PartialView(item);
        }
        [UserAuthFilter]
        public ActionResult MemberAct()
        {


            return PartialView();
        }

        public ActionResult Map()
        {


            return PartialView();
        }

        public ActionResult Mefoot()
        {


            return PartialView();
        }

        [UserAuthFilter]
        public ActionResult MemberEvent()
        {


            return View();
        }

        //public ActionResult EventMenu()
        //{


        //    return PartialView();
        //}

        public ActionResult EventJoin()
        {


            return PartialView();
        }

        public ActionResult EventInitiate()
        {


            return PartialView();
        }
        public ActionResult EventHistory()
        {


            return PartialView();
        }
        [UserAuthFilter]
        public ActionResult MemberMessy()
        {


            return View();
        }

        public ActionResult MyMessy()
        {


            return PartialView();
        }

        public ActionResult MessyHistory()
        {


            return PartialView();
        }
        [UserAuthFilter]
        public ActionResult MePassword()
        {


            return View();
        }
        //[HttpPost]
        //public ActionResult MePassword()
        //{


        //    return View();
        //}

        public ActionResult ChangeMePassword()
        {


            return PartialView();
        }
        [UserAuthFilter]
        public ActionResult MePoints()
        {


            return View();
        }

        public ActionResult CurrentPoints()
        {


            return PartialView();
        }

        public ActionResult RedeemPoints()
        {


            return PartialView();
        }

        [UserAuthFilter]
        public ActionResult MemberEdit()
        {
            int id = UserVm.LoginUser.UserId;
            var item = this.Userver.findByid(id);
            var item0 = this.Userver.ChatUsre(item);
            var SelectSex = new List<SelectListItem>()
            {
              new SelectListItem {Text="生理男性", Value="0" },
              new SelectListItem {Text="生理女性", Value="1" },
              new SelectListItem {Text="其他", Value="2" },
            };

            //預設選擇哪一筆
            SelectSex.Where(q => q.Value == "0").First().Selected = true;

            ViewBag.SelectSite = SelectSex;


            return View(item0);
        }

        [UserAuthFilter]
        [HttpPost]
        public ActionResult MemberUpate(UpdateUserVm item)
        {
            this.UpdateJpg.UserUpJpg(item.Photo[0]);
            item.id = UserVm.LoginUser.UserId;

            var item0 = this.Userver.ChatUpdate(item);
            this.Userver.Update(item0);

            return RedirectToAction("Member");
        }




    }
}