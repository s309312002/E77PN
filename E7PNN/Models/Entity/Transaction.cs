using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace E7PNN.Models
{

    public partial class Transaction
    {
        public int ID { get; set; }
        
        public int Member_ID { get; set; }

        public int Prize_ID { get; set; }

        public DateTime BuyTime { get; set; }

        public int Amount { get; set; }

        public DateTime ExchangeTime { get; set; }

        public DateTime EndchangeTime { get; set; }

      

    }
}