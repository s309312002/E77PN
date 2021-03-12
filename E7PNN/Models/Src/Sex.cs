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
    public enum Sex
    {
        [Display(Name = "生理男性")]
        Man = 0,

        [Display(Name = "生理女性")]
        Woman = 1,

        [Display(Name = "其他")]
        Other = 2,
    }
}