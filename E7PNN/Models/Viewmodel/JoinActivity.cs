using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E7PNN.Models.ViewModel
{
    public class JoinActivityVm
    {
        public int Member_ID { get; set; }

        public int Act_ID { get; set; }

        public DateTime UpdateTime { get; set; }

        public string ActSite { get; set; }

        public string ActName { get; set; }

        public int ActType { get; set; }


    }
}