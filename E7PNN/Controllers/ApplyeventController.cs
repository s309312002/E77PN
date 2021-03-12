using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using E7PNN.Models;
using E7PNN.Models.ViewModel;
using E7PNN.Server;
using E7PNN.Sevice;
using E7PNN.Models.Auth;

namespace E7PNN.Controllers
{
    public class ApplyeventController : Controller
    {
        private UserTbDbTool Userserve;
        private ActivityDbTool Actsever;
        private CreateEventDbTool Eventserver;
        private EditAnnounceDbTool Annserver;
        public ApplyeventController()
        {
            var Db = new E7pnnContext();
            this.Userserve = new UserTbDbTool(Db);
            this.Actsever = new ActivityDbTool(Db);
            this.Eventserver = new CreateEventDbTool(Db);
            this.Annserver = new EditAnnounceDbTool(Db);
        }
  
        // GET: Applyevent
        [UserAuthFilter]
        public ActionResult ApplyEvents()
        {

            int id = UserVm.LoginUser.UserId;
            var item =this.Eventserver.UserDatex(id);
            var selectSite = new List<SelectListItem>()
            {
       new SelectListItem {Text="新北白沙灣", Value="1" },
        new SelectListItem {Text="宜蘭南澳神秘沙灘", Value="2" },
        new SelectListItem {Text="宜蘭外澳沙灘", Value="3" },
        new SelectListItem {Text="花蓮北濱公園", Value="4" },
            };

            //預設選擇哪一筆
            selectSite.Where(q => q.Value == "1").First().Selected = true;

            ViewBag.selectSite = selectSite;

            var selectClass = new List<SelectListItem>()
            {
        new SelectListItem {Text="未選擇", Value="0" },
        new SelectListItem {Text="個人", Value="1" },
        new SelectListItem {Text="團體", Value="2" },

            };

            //預設選擇哪一筆
            selectClass.Where(q => q.Value == "0").First().Selected = true;

            ViewBag.selectClass = selectClass;

            return View(item);
        }
        // POST
        [HttpPost]
        public ActionResult ApplyEvents(EditActivityVm item)
        {


            this.Eventserver.FixedEdit(item);

            return RedirectToAction("ApplyMenu", item);



        }

        public ActionResult applytext()
        {


            return PartialView();
        }

        [UserAuthFilter]
        public ActionResult ApplyEventsFast()
        {

            int id = UserVm.LoginUser.UserId;
            var item = this.Eventserver.UserDatex(id);

            var selectType = new List<SelectListItem>()
            {
        new SelectListItem {Text="淨灘", Value="1" },
        new SelectListItem {Text="淨山", Value="2" },
        new SelectListItem {Text="淨路", Value="3" },
            };

            //預設選擇哪一筆
            selectType.Where(q => q.Value == "1").First().Selected = true;

            ViewBag.SelectType = selectType;

            var SelectSite = new List<SelectListItem>()
    {
        new SelectListItem {Text="新北白沙灣", Value="1" },
        new SelectListItem {Text="宜蘭南澳神秘沙灘", Value="2" },
        new SelectListItem {Text="宜蘭外澳沙灘", Value="3" },
        new SelectListItem {Text="花蓮北濱公園", Value="4" },
    };

            //預設選擇哪一筆
            SelectSite.Where(q => q.Value == "1").First().Selected = true;

            ViewBag.SelectSite = SelectSite;


            return View(item);
        }
        // POST
        [HttpPost]
        public ActionResult ApplyEventsFast(EditActivityVm item)
        {


            this.Eventserver.FstrEdit(item);

            return RedirectToAction("ApplyMenu", item);



        }

        public ActionResult applytextFast()
        {


            return PartialView();
        }
   
        [UserAuthFilter]
        public ActionResult ApplyMountain()
        {
            int id = UserVm.LoginUser.UserId;
            var item = this.Eventserver.UserDatex(id);

            var selectSite = new List<SelectListItem>()
            {
       new SelectListItem {Text="阿里山", Value="1" },
        new SelectListItem {Text="大霸尖山", Value="2" },
        new SelectListItem {Text="玉山", Value="3" },
        new SelectListItem {Text="太平山", Value="4" },
            };

            //預設選擇哪一筆
            selectSite.Where(q => q.Value == "1").First().Selected = true;

            ViewBag.selectSite = selectSite;

            var selectClass = new List<SelectListItem>()
            {
        new SelectListItem {Text="未選擇", Value="0" },
        new SelectListItem {Text="個人", Value="1" },
        new SelectListItem {Text="團體", Value="2" },

            };

            //預設選擇哪一筆
            selectClass.Where(q => q.Value == "0").First().Selected = true;

            ViewBag.selectClass = selectClass;

            return View(item);
        }
        // POST
        [HttpPost]
        public ActionResult ApplyMountain(EditActivityVm item)
        {


            this.Eventserver.FixedEdit(item);

            return RedirectToAction("ApplyMenu", item);



        }

        public ActionResult applytextMountain()
        {


            return PartialView();
        }

        [UserAuthFilter]
        public ActionResult ApplyRoad()
        {
            int id = UserVm.LoginUser.UserId;
            var item = this.Eventserver.UserDatex(id);

            var selectSite = new List<SelectListItem>()
            {
       new SelectListItem {Text="路1", Value="1" },
        new SelectListItem {Text="路2", Value="2" },
        new SelectListItem {Text="路3", Value="3" },
        new SelectListItem {Text="路4", Value="4" },
            };

            //預設選擇哪一筆
            selectSite.Where(q => q.Value == "1").First().Selected = true;

            ViewBag.selectSite = selectSite;

            var selectClass = new List<SelectListItem>()
            {
        new SelectListItem {Text="未選擇", Value="0" },
        new SelectListItem {Text="個人", Value="1" },
        new SelectListItem {Text="團體", Value="2" },

            };

            //預設選擇哪一筆
            selectClass.Where(q => q.Value == "0").First().Selected = true;

            ViewBag.selectClass = selectClass;

            return View(item);
        }
        // POST
        [HttpPost]
        public ActionResult ApplyRoad(EditActivityVm item)
        {


            this.Eventserver.FixedEdit(item);

            return RedirectToAction("ApplyMenu", item);



        }

        public ActionResult applytextRoad()
        {


            return PartialView();
        }
    
        [UserAuthFilter]
        public ActionResult ApplyMessy()
        {
            var selectType = new List<SelectListItem>()
            {
        new SelectListItem {Text="淨灘", Value="1" },
        new SelectListItem {Text="淨山", Value="2" },
        new SelectListItem {Text="淨路", Value="3" },
            };

            //預設選擇哪一筆
            selectType.Where(q => q.Value == "1").First().Selected = true;

            ViewBag.SelectType = selectType;

            var SelectSite = new List<SelectListItem>()
            {
              new SelectListItem {Text="新北白沙灣", Value="1" },
              new SelectListItem {Text="宜蘭南澳神秘沙灘", Value="2" },
              new SelectListItem {Text="宜蘭外澳沙灘", Value="3" },
              new SelectListItem {Text="花蓮北濱公園", Value="4" },
              new SelectListItem {Text="其他", Value="5" },

            };

            //預設選擇哪一筆
            SelectSite.Where(q => q.Value == "1").First().Selected = true;

            ViewBag.SelectSite = SelectSite;


            return View();
        }

        [HttpPost]
        public ActionResult ApplyMessy(EditAnnounceVm item)
        {
            int Id = UserVm.LoginUser.UserId;

            var data = this.Annserver.EditAnnounce(item,Id);



           // return RedirectToAction("Member", "EventMenu");



            return RedirectToAction("ApplyMenu", item);





        }

   

        public ActionResult applytextMessy()
        {


            return PartialView();
        }

        public ActionResult ApplyMenu()
        {
            return View();
        }

    }
}