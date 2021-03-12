using System;
using System.Web;
using System.Web.Mvc;
using E7PNN.Models;
using E7PNN.Models.Auth;
using E7PNN.Models.ViewModel;
using E7PNN.Server;

namespace E7PNN.Controllers
{
    public class LonigController : Controller
    {

        private LoginDbTool Server;
        private UserTbDbTool UserTb;

        public LonigController()
        {
            var Db = new E7pnnContext();
            this.Server = new LoginDbTool(Db);
            this.UserTb = new UserTbDbTool(Db);
        }
        // GET: Lonig
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {

            if (Request.Cookies["cookie"] != null)
            {
                this.Response.Cookies["cookie"].Expires = DateTime.Now.AddDays(-1);
            }

            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        //Post
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(LoginViewModel model) 
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            if (this.Server.login(model.Email, model.Password))
            {
                var cookieName = LoginDbTool.CookieName;
                var token = this.Server.genToken(model.Email);
                var cookie = new HttpCookie(cookieName, token); ;
                this.Response.Cookies.Add(cookie);
                return RedirectToAction("Index", "Home");
            }
            else 
            {
                ModelState.AddModelError("", "登入嘗試失敗。");
                model.Password = string.Empty;
                return View(model); 
            }
        }
  
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Signup() 
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        [EditUser]
        public ActionResult Signup(SignupVm User) 
        {
            if (ModelState.IsValid)
            {
                    return View(User);
            }
            if (this.Server.UserInsert(User.Email))
            {
               var xx = this.Server.Join(User);
                this.UserTb.Insert(xx);
                return RedirectToAction("Login", "Lonig");
            }
            ModelState.AddModelError("", "帳號重複");
            return View(User);
        }



        public ActionResult Forget() 
        {
            return View();
        }

        public ActionResult Forget(ForgetVm User)
        {
            if (ModelState.IsValid)
            {
                return View(User);
            }
            if (this.Server.ForgetNum(User.Email))
            {
                return RedirectToAction("Login", "Update");
            }

            ModelState.AddModelError("", "查無帳號");
            return View();
        }

        public ActionResult Update() 
        {
            return View();
        }


        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        [Forget]
        public ActionResult Update(ForgetVm User)
        {
            if (ModelState.IsValid)
            {
                return View(User);
            }

            this.UserTb.UpForgetNumber(User);


            return RedirectToAction("Login", "Lonig");
      
        }
    }
}