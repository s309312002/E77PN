using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace E7PNN.Models.Src
{
    /// <summary>
    /// 狀態
    /// </summary>
    public enum Status
    {
        [Display(Name = "未認證")]
        None = 0,

        [Display(Name = "正常")]
        Start = 1,

        [Display(Name = "停用")]
        Stop = 2,

        [Display(Name = "審核中")]
        Review = 3,

        [Display(Name = "舉辦中")]
        Via = 4,

        [Display(Name = "不通過")]
        UnVia = 5,

        [Display(Name = "已處理")]
        UnSurre = 6,


    }
}