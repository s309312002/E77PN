using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace E7PNN.Models.Src
{
    public enum AnnType
    {
        [Display(Name = "未設定")]
        Report = 0,

        [Display(Name = "淨攤")]
        beach = 1,

        [Display(Name = "淨山")]
        hill = 2,

        [Display(Name = "淨路")]
        Road = 3,

        [Display(Name = "其他")]
        Other = 4,
    }
}