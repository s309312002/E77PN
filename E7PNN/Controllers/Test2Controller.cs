using CSHttpClientSample;
using E7PNN.Models;
using E7PNN.Models.ViewModel;
using E7PNN.Sevice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E7PNN.Controllers
{
    public class Test2Controller : Controller
    {
        private UpdateJpg updateJpg;
        public Test2Controller()
        {
            this.updateJpg = new UpdateJpg();
        }

        // GET: Test2
        public ActionResult Index()
        {
            Program.Main();

            return View();
        }

        [HttpPost]
        public ActionResult UpJpgg(Test2Vm Pic1) 
        {
           for(int x = 0;  x < Pic1.Files.Count; x++)
                this.updateJpg.UpJpg(Pic1.Files[x], x+1);
            
            return null;
        }
    }
}