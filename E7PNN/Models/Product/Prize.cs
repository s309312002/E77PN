namespace E7PNN.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [MetadataType(typeof(PrizeMetadata))]
    public partial class Prize
    {
        private class PrizeMetadata
        {
            [Display(Name = "獎品編號")]
            public int ID { get; set; }

            [Display(Name = "獎品名稱")]
            [Required]
            public string PrizeName { get; set; }

            [Display(Name = "庫存量")]
            public int Stock { get; set; }

            [Display(Name = "更新時間")]
            public DateTime UpdateTime { get; set; }


        }
    }
}