namespace E7PNN.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [MetadataType(typeof(ExpMetadata))]
    public partial class Exp
    {
        private class ExpMetadata
        {
            [Display(Name = "經驗編號")]
            public int ID { get; set; }

            [Display(Name = "經驗累積")]
            public string SumExp { get; set; }

            [Display(Name = "等級")]
            public string Level { get; set; }

            [Display(Name = "會員編號")]
            public int User_ID { get; set; }


        }
    }
}