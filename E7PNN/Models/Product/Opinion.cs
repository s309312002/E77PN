namespace E7PNN.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using E7PNN.Models.Src;

    [MetadataType(typeof(OpinionMetadata))]
    public partial class Opinion
    {
        private class OpinionMetadata
        {
            [Display(Name = "意見編號")]
            public int ID { get; set; }

            [Display(Name = "會員編號")]
            [Required]
            public int Member_ID { get; set; }

            [Display(Name = "意見分類")]
            public OpiType OpiType { get; set; }

            [Display(Name = "意見內容")]
            [Required]
            public string OpiText { get; set; }

            [Display(Name = "檔案名稱")]
            public string FileName { get; set; }

            [Display(Name = "填表時間")]
            public DateTime CreateTime { get; set; }

        }
    }
}