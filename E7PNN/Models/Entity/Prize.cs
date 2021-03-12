namespace E7PNN.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;


    public partial class Prize
    {

        public int ID { get; set; }

        public string PrizeName { get; set; }

        public int Stock { get; set; }

        public DateTime UpdateTime { get; set; }

    
    }
}
