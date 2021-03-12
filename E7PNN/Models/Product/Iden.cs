namespace E7PNN.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [MetadataType(typeof(IdenMetadata))]
    public partial class Iden
    {
        private class IdenMetadata
        {
            [Display(Name = "身分編號")]
            public int ID { get; set; }

            [Display(Name = "身分")]
            public string IdenName { get; set; }



        }
    }
}