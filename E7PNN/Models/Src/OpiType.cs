using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace E7PNN.Models.Src
{
    public enum OpiType
    {
        [Display(Name = "檢舉")]
        Report = 0,

        [Display(Name = "系統問題")]
        Bug = 1,

        [Display(Name = "其他建議")]
        Other = 2,

        [Display(Name = "活動發享")]
        Share = 3,

    }
}