namespace E7PNN.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [MetadataType(typeof(LikeMetadata))]
    public partial class Like
    {
        private class LikeMetadata
        {
            [Display(Name = "收藏編號")]
            public int ID { get; set; }

            [Display(Name = "會員編號")]
            public int Member_ID { get; set; }

            [Display(Name = "場次編號")]
            public int Act_ID { get; set; }



        }
    }
}