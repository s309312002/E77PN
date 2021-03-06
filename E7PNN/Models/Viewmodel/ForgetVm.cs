using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace E7PNN.Models.ViewModel
{
    public class ForgetVm
    {
        [Required]
        [StringLength(100, ErrorMessage = "{0} 的長度至少必須為 {2} 個字元。", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "密碼")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "確認密碼")]
        [Compare("Password", ErrorMessage = "密碼和確認密碼不相符。")]
        public string Password_pass { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public int ID { get; set; }

        public static ForgetVm Forget(UserTb user)
        {
            var UserTbs = new ForgetVm()
            {
                Email = user.Email,
                ID = user.ID
            };
            return UserTbs;
        }

    }


}