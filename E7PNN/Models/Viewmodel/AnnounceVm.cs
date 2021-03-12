using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace E7PNN.Models.ViewModel
{
    public class AnnounceVm
    {
    }
    public class EditAnnounceVm
    {
        public DateTime AnnTime { get; set; }

        public string AnnName { get; set; }

        public int AnnType { get; set; }

        public int Member_ID { get; set; }

        public string AnnSite { get; set; }

        public string AnnText { get; set; }

        public string AnnLong { get; set; }

        public string AnnLat { get; set; }

        public int AnnStatus { get; set; }

        [Display(Name = "檔案名稱")]
        public List<HttpPostedFileBase> PicFileName { get; set; }

    }

    public class Test2Vm 
    {
        [Display(Name = "姓名")]
        public string Pic2 { get; set; }

        [Display(Name = "姓名")]
        public HttpPostedFileBase Pic1 { get; set; }

        public List<HttpPostedFileBase> Files { get; set; }
        // Rest of model details 
    }
}