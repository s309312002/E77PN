namespace E7PNN.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using E7PNN.Models.Src;

    public partial class Announce
    {   
        public int ID { get; set; }
     
        public DateTime AnnTime { get; set; }
      
        public string AnnSite { get; set; }

        public AnnType AnnType { get; set; }
   
        public string AnnUser { get; set; }

        public string AnnText { get; set; }

        public int Member_ID { get; set; }

        public string Pic1 { get; set; }

        public string Pic2 { get; set; }
   
        public string Pic3 { get; set; }

        public string Pic4 { get; set; }

        public string Pic5 { get; set; }

        public Status Status { get; set; }

        public string AnnLong { get; set; }

        public string AnnLat { get; set; }

        public string Cause { get; set; }

   
    }
}
