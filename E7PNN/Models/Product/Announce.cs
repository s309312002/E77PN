namespace E7PNN.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using E7PNN.Models.Src;

    [MetadataType(typeof(AnnounceMetadata))]
    public partial class Announce
    {
        private class AnnounceMetadata
        {
            [Display(Name = "通報編號")]
            public int ID { get; set; }

            [Display(Name = "時間")]
            public DateTime AnnTime { get; set; }

            [Display(Name = "地點")]
            [Required]
            public string AnnSite { get; set; }

            [Display(Name = "類型")]
            public AnnType AnnType { get; set; }

            [Display(Name = "申請人")]
            [Required]
            public string AnnUser { get; set; }

            [Display(Name = "會員編號")]
            [Required]
            public int Member_ID { get; set; }

            [Display(Name = "內容")]
            [Required]
            public string AnnText { get; set; }

            [Display(Name = "照片")]
            [Required]
            public string Pic1 { get; set; }

            [Display(Name = "照片")]
            [Required]
            public string Pic2 { get; set; }

            [Display(Name = "照片")]
            [Required]
            public string Pic3 { get; set; }

            [Display(Name = "照片")]
            [Required]
            public string Pic4 { get; set; }

            [Display(Name = "照片")]
            [Required]
            public string Pic5 { get; set; }

            [Display(Name = "狀態")]
            public Status Status { get; set; }

            [Display(Name = "經度")]
            [Required]
            public string AnnLong { get; set; }

            [Display(Name = "緯度")]
            [Required]
            public string AnnLat { get; set; }

            [Display(Name = "備註")]
            public string Cause { get; set; }


        }
    }
}