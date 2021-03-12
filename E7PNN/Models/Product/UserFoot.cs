namespace E7PNN.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [MetadataType(typeof(UserFootMetadata))]
    public partial class UserFoot
    {
        private class UserFootMetadata
        {
            [Display(Name = "個人足跡編號")]
            public int ID { get; set; }

            [Required]
            [Display(Name = "會員編號")]
            public int Member_ID { get; set; }

            [Required]
            [Display(Name = "場次編號")]
            public int Act_ID { get; set; }

       

        }
    }
}