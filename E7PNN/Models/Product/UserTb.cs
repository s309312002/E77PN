namespace E7PNN.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using E7PNN.Models.Src;

    [MetadataType(typeof(UserTbMetadata))]
    public partial class UserTb
    {
        private class UserTbMetadata
        {
            [Display(Name = "User編號")]
            public int ID { get; set; }

            [Display(Name = "會員帳號")]
            [StringLength(30,
                                        ErrorMessage ="{0} 的長度需介於{2}到{1}.",
                                        MinimumLength = 4)]
            public string UserNember { get; set; }

            [Display(Name = "會員密碼")]
            [StringLength(30,ErrorMessage = "{0} 的長度需介於{2}到{1}.",MinimumLength = 4)]
            [Required]
            public string MiNember { get; set; }

            [Display(Name = "身分")]
            public int Iden_ID { get; set; }

            [Display(Name = "狀態")]
            public Status Status { get; set; }

            [Display(Name = "電子信箱")]
            [Required]
            [EmailAddress]
            public string Email { get; set; }

            [Display(Name = "積分")]
            public int Points { get; set; }

            [Display(Name = "姓名")]
            [StringLength(30,ErrorMessage = "{0}長度不可以超過{1}.")]
            public string Name { get; set; }

            [Display(Name = "電話")]
            [Phone]
            public string Phone { get; set; }

            [Display(Name = "個簽")]
            public string UserText { get; set; }

            [Display(Name = "性別")]
            public Sex Sex { get; set; }

            [Display (Name="暱稱")]
            public string Niname { get; set; }

            [Display(Name = "創建時間")]
            public DateTime CreateDate { get; set; }

      



        }
    }
}