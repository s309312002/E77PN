namespace E7PNN.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using E7PNN.Models.Src;

    public partial class Opinion
    {
    
        public int ID { get; set; }

        public int Member_ID { get; set; }

        public OpiType OpiType { get; set; }

        public string FileName { get; set; }

        public string OpiText { get; set; }

        public DateTime CreateTime { get; set; }


    }
}
