namespace E7PNN.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using E7PNN.Models.Src;

    [MetadataType(typeof(JoinAccMetadata))]
    public partial class JoinAcc
    {
        private class JoinAccMetadata
        {
            [Display(Name = "收藏編號")]
            public int ID { get; set; }

            [Display(Name = "會員編號")]
            public int Member_ID { get; set; }

            [Display(Name = "場次編號")]
            public int Act_ID { get; set; }

            [Display(Name = "更新時間")]
            public DateTime UpdateTime { get; set; }

            [Display(Name = "狀態")]
            public int JoinStatus { get; set; }


        }
    }
}