using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using E7PNN.Models;
using E7PNN.Models.Auth;
using E7PNN.Models.ViewModel;
using E7PNN.Server;

namespace E7PNN.Controllers
{
    
    public class HomeController : Controller
    {
        private UserTbDbTool Userserve;
        private ActivityDbTool Actsever;
        public HomeController()
        {
            var Db = new E7pnnContext();
            this.Userserve = new UserTbDbTool(Db);
            this.Actsever = new ActivityDbTool(Db);
        }


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Recent()
        {
            var item = this.Actsever.FindNew();
                 
                

            return PartialView(item);
        }

        public ActionResult Notice(NewestActivityVm model)
        {
            this.Actsever.UnsolvedCount();


            return PartialView(model);
        }
            public ActionResult Ranking()
        {


            return PartialView();
        }
        public ActionResult Questions()
        {


            return PartialView();
        }
        public ActionResult Contacts()
        {


            return PartialView();
        }






    }
}