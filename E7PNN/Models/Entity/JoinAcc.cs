namespace E7PNN.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using E7PNN.Models.Src;

    public partial class JoinAcc
    {
        
        public int ID { get; set; }

        public int Act_ID { get; set; }

        public int Member_ID { get; set; }

        public DateTime UpdateTime { get; set; }

        public int JoinStatus { get; set; }


    }
}
