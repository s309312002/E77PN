namespace E7PNN.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

 
    public partial class Exp
    {
   
        public int ID { get; set; }

        public string SumExp { get; set; }

        public string Level { get; set; }

        public int User_ID { get; set; }

        public virtual UserTb UserTb { get; set; }
    }
}
