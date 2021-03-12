using Jose;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using E7PNN.Models;
using E7PNN.Models.ViewModel;

namespace E7PNN.Server
{
    public class LoginDbTool : ServiceBase 
    {
        public static readonly string CookieName = "cookie";
        public static readonly string TokenSecret = "secret";
        private UserTbDbTool UserTb ;

        public LoginDbTool(E7pnnContext Db):base(Db)
        {

            var db = new E7pnnContext();
            this.UserTb = new UserTbDbTool(db);
        }
        public bool login(string acc, string pwd)
        {
            
            var user = this.UserTb.FindAll().FirstOrDefault(p => p.Email == acc && p.MiNember == pwd); 
            if (user == null)
                return false;
            UserVm.Login(user);
            return true;
        }



        public string genToken(string acc)
        {
            var payload = new CookiePayload() { acc = acc };
            var key = Encoding.UTF8.GetBytes(TokenSecret);
            var token = JWT.Encode(payload, key, JwsAlgorithm.HS256);
            return token;
        }

        public string checkToken(string token)
        {
            var key = Encoding.UTF8.GetBytes(TokenSecret);
            var payload = JWT.Decode<CookiePayload>(token, key, JwsAlgorithm.HS256);
            if (payload == null)
                return string.Empty;
            return payload.acc;
        }


        private class CookiePayload
        {
            public string acc { get; set; }
        }

        public bool UserInsert(string Emaill)
        {
            var user = this.UserTb.FindAll().FirstOrDefault(p => p.Email == Emaill);

            if (user == null)
                return true;

            return false;
        }

        public UserTb Join(SignupVm item)
        {
            var Join = new UserTb
            {
                Email = item.Email,
                MiNember = item.Password,
                Name = item.Fullname
            };

            return Join;
        }


        public bool ForgetNum(string Emaill)
        {
            var user = this.UserTb.FindAll().FirstOrDefault(p => p.Email == Emaill);

            if (user != null)
            {
                ForgetVm.Forget(user);
                return true;
            }
            return false;
        }

        public UserTb ForgerPassnumber(ForgetVm item)
        {
            var Join = new UserTb
            {
                Email = item.Email,
                MiNember = item.Password,
            };

            return Join;
        }



    }
}