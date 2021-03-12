using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E7PNN.Models.ViewModel
{
    public class ActivityVm
    {
        public int Count { get; set; }

        public int Type { get; set; }
  

    }

    public class NewestActivityVm
    {
        public int UnsolvedCount { get; set; }

        public int SolvedCount { get; set; }

        public int PastActivityCount { get; set; }
    }

    







}