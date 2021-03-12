using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace E7PNN.Models.ViewModel
{
    public class UserVm
    {
        public string Acc { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }

        public static UserVm LoginUser { get; private set; }
        public static UserVm Login(UserTb user)
        {
            LoginUser = (user == null) ? null : new UserVm()
            {
                Acc = user.Email,
                Name = user.Name,
                UserId = user.ID,
            };
            return LoginUser;
        }
        public static void logout()
        {
            LoginUser = null;
        }
        public static bool IsLogin => LoginUser != null;
    }

    public class SignupVm
    {
        [Required]
        [StringLength(100, ErrorMessage = "{0} 的長度至少必須為 {2} 個字元。", MinimumLength = 6)]
        [Display(Name = "姓名")]
        public string Fullname { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "信箱")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "{0} 的長度至少必須為 {2} 個字元。", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "密碼")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "確認密碼")]
        [Compare("Password", ErrorMessage = "密碼和確認密碼不相符。")]
        public string Password_pass { get; set; }

    }

    public class UpdateUserVm
    {
        public int id { get; set; }
        
        [Display(Name = "姓名")]
        public string Fullname { get; set; }

      
        [Display(Name = "信箱")]
        public string Email { get; set; }

       
        [Display(Name = "暱稱")]
        public string NiName { get; set; }

        [Display(Name = "電話")]
        public string Phone { get; set; }

        [Display(Name = "性別")]
        public int Sex { get; set; }

        [Display(Name = "生日")]
        public string Bireday { get; set; }

        [Display(Name = "大頭貼")]
        public List<HttpPostedFileBase> Photo { get; set; }



    }




}