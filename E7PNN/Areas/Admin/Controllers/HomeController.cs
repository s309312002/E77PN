using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using E7PNN.Models;
using E7PNN.Server;
using E7PNN.Models.ViewModel;

namespace E7PNN.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        private UserTbDbTool server;
        private ActivityDbTool Asever;
        public HomeController()
        {
            var Db = new E7pnnContext();
            this.server = new UserTbDbTool(Db);
            this.Asever = new ActivityDbTool(Db); 
        }

        // GET: Admin/Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult users()
        {

            var user = this.server.FindAll();

            return View(user);
        }
        public ActionResult teams()
        {

           
            return View();
        }
        //public ActionResult teams(string teamSum)
        //{
        //    var count = db.Team
        //        .Sum(m=>m. )
                
        //}

        public ActionResult ActivitySummary()
        {
            return View();
        }
        public ActionResult Gift()
        {
            return View();
        }
        public ActionResult EmegencyNotice()
        {
            return View();
        }
        public ActionResult YearsSummary()
        {
            var Act = this.Asever.FindAll();

            return View(Act);
        }
        public ActionResult Useredit(int id)
        {

            var item = this.server.findByid(id);

            return View(item);
        }
        //[HttpPost]
        //public ActionResult Useredit(UserTb item)
        //{
            
        //    var item0 = this.server.Update(item);

        //    return View(item);
        //}
        public ActionResult Userdetails(int id) 
        { 
        
            var item = this.server.findByid(id);

            return View(item);
        }
        public ActionResult YesDetails(int id)
        {

            var item = this.Asever.FindId(id);

            return View(item);
        }
        public ActionResult Nodetails(int id)
        {

            var item = this.Asever.FindId(id);

            return View(item);
        }

    }
}