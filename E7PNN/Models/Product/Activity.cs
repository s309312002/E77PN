namespace E7PNN.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using E7PNN.Models.Src;

    [MetadataType(typeof(ActivityMetadata))]
    public partial class Activity
    {
        private class ActivityMetadata
        {
            [Display(Name = "場次編號")]
            public int ID { get; set; }

            [Display(Name = "場次名稱")]
            [Required]
            public string ActName { get; set; }

            [Display(Name = "時間")]
            public DateTime ActTime { get; set; }

            [Display(Name = "地點")]
            [Required]
            public string ActSite { get; set; }

            [Display(Name = "類型")]
            public AnnType ActType { get; set; }

            [Display(Name = "主辦人")]
            [Required]
           public string ActUser { get; set; }

            [Display(Name = "會員編號")]
            [Required]
            public int Member_ID { get; set; }

            [Display(Name = "人數")]
            [Required]
            public string SumPeople { get; set; }

            [Display(Name = "內容")]
            [Required]
            public string ActText { get; set; }

            [Display(Name = "場次類型")]
            public ActClass ActClass { get; set; }

            [Display(Name = "狀態")]
            public Status ActStatus { get; set; }

            [Display(Name = "經度")]
            [Required]
            public string ActLong { get; set; }

            [Display(Name = "緯度")]
            [Required]
            public string ActLat { get; set; }

            [Display(Name = "備註")]
            public string Cause { get; set; }

            [Display(Name = "開始時間")]
            [Required]
            public DateTime StatTime { get; set; }

            [Display(Name = "結束時間")]
            [Required]
            public DateTime EndTime { get; set; }


        }
    }
}