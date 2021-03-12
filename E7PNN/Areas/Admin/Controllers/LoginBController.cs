using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.Mvc;
using E7PNN.Models;
using E7PNN.Server;
using E7PNN.Sevice;


namespace E7PNN.Areas.Admin.Controllers
{
    public class LoginBController : Controller
    {
        private UserTbDbTool Userver;
        public LoginBController()
        {
            var Db = new E7pnnContext();
            this.Userver = new UserTbDbTool(Db);
        }
            // GET: Admin/Login
            public ActionResult Index()
        {

            return View();
        }
        public ActionResult Signin()
        {

            return View();
        }
        //        [HttpPost]
        //        public ActionResult Signin(FormCollection post)
        //        {
        //            string account = post["account"];
        //            string password = post["password1"];

        //            //驗證帳號密碼
        //            var checkU = this.Userver.FindAll()
        //           .Where(m => m.UserNember == account)
        //            .SingleOrDefault();

        //            var checkM = this.Userver.FindAll()
        //                 .Where(n => n.MiNember == password)
        //                 .SingleOrDefault();


        //            if (checkU != null && checkM != null)
        //            {
        //                Session["account"] = account;

        //                Response.Redirect("~/Admin/Home/index");
        //                return new EmptyResult();
        //            }
        //            else
        //            {
        //                ViewBag.Msg = "登入失敗...";
        //                return View();
        //            }




        //        }


    }

}
