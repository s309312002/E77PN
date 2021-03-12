using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using E7PNN.Models;
using E7PNN.Models.ViewModel;
using E7PNN.Server;
using E7PNN.Models.Auth;

namespace E7PNN.Controllers
{
    public class JoinEventController : Controller
    {
        private UserTbDbTool Userserve;
        private ActivityDbTool Actsever;
        private JoinActivityDbTool Jactsever;
        public JoinEventController()
        {
            var Db = new E7pnnContext();
            this.Userserve = new UserTbDbTool(Db);
            this.Actsever = new ActivityDbTool(Db);
            this.Jactsever = new JoinActivityDbTool(Db);
        }

        [UserAuthFilter]
        public ActionResult JoinEvent()
        {

         var item = this.Actsever.FindAll();
            


            return View(item);
        }
        [HttpPost]
        public ActionResult JoinEvent(int ActId)
        {

            this.Jactsever.GetAllJoinUser(ActId);

            return RedirectToAction("MemberEvent", ActId);

        }

        public ActionResult Events(int id)
        {
            var item = this.Actsever.FindId(id);

            return View(item);
        }








    }
}
