namespace E7PNN.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using E7PNN.Models.Src;

    public partial class Activity
    {
     
        public int ID { get; set; }

 
        public string ActName { get; set; }


        public DateTime ActTime { get; set; }

        public int Member_ID { get; set; }
        
        public string ActSite { get; set; }

        public AnnType ActType { get; set; }

        public DateTime StatTime { get; set; }

        public DateTime EndTime { get; set; }

        public string ActUser { get; set; }

 
        public string SumPeople { get; set; }


        public string ActText { get; set; }


        public ActClass ActClass { get; set; }


        public Status ActStatus { get; set; }


        public string ActLong { get; set; }


        public string ActLat { get; set; }

        public string Cause { get; set; }

      

    }
}
