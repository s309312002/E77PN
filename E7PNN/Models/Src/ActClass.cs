using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace E7PNN.Models.Src
{
    public enum ActClass
    {
        [Display(Name ="未選擇")]
        Noce = 0,

        [Display(Name = "個人")]
        Fixed = 1,

        [Display(Name = "團體")]
        Group = 2,

        [Display(Name = "自由")]
        Free = 3,

        [Display(Name = "臨時")]
        Tempo = 4,

    }
}