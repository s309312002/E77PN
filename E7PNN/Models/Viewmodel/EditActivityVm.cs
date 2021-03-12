using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E7PNN.Models.ViewModel
{
    public class EditActivityVm
    {
        public string ActName { get; set; }
        public DateTime ActTime { get; set; }
        public int Member_ID { get; set; }
        public int ActType { get; set; }
        public string SumPeople { get; set; }
        public string Text { get; set; }
        public string ActSite { get; set; }
        public string Email { get; set; }
        public string Number { get; set; }
        public DateTime StarTime { get; set; }
        public DateTime EndTime { get; set; }
        public string ActLong { get; set; }
        public string ActLat { get; set; }
        public int ActClass { get; set; }

    }

    public class AllJoinUserVm
    {
        public int Member_ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Status { get; set; }
        public DateTime StarTime { get; set; }
    }
}