namespace E7PNN.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using E7PNN.Models.Src;

    public partial class UserTb
    {
        public int ID { get; set; }

        public string UserNember { get; set; }

        public string MiNember { get; set; }

        public int Iden_ID { get; set; }

        public Status Status { get; set; }

        public string Email { get; set; }

        public int Points { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string UserText { get; set; }

        public Sex Sex { get; set; }

        public string Niname { get; set; }

        public DateTime CreateDate { get; set; }


        public IList<Exp> Exp { get; set; }


    }
}
