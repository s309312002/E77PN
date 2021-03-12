namespace E7PNN.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [MetadataType(typeof(TransactionMetadata))]
    public partial class Transaction
    {
        private class TransactionMetadata
        {
            [Display(Name = "交易編號")]
            public int ID { get; set; }

            [Required]
            [Display(Name = "會員編號")]
            public int Member_ID { get; set; }

            [Required]
            [Display(Name = "商品編號")]
            public int Prize_ID { get; set; }

            [Display(Name = "購買時間")]
            public DateTime BuyTime { get; set; }

            [Display(Name = "商品數量")]
            public int Amount { get; set; }

            [Display(Name = "閱換時間")]
            public DateTime ExchangeTime { get; set; }

            [Display(Name = "到期時間")]
            public DateTime EndchangeTime { get; set; }



        }
    }
}