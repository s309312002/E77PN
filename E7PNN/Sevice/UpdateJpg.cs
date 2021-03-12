using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Drawing;
using E7PNN.Server;
using E7PNN.Models;
using System.Web.Mvc;

namespace E7PNN.Sevice
{
    public class UpdateJpg
    {
      
  
        public int UpJpg(HttpPostedFileBase photoFile,int id)
        {
            //如果有上傳成功
            if (photoFile != null)
            {
                //圖片結尾是否為gif|png|jpg|bmp
                if (CheckPhotoFormat(photoFile.FileName))
                {
        
            
                        //大小>0byte
                        if (photoFile.ContentLength > 0)
                        {
                            //檔案名
                            var fileName = "Catch"+id+ ".jpg";
                            //路徑
                           var path = Path.Combine(HttpContext.Current.Server.MapPath("~/GetJpg/"));
                            //路徑加檔案名
                            var pathName = Path.Combine(HttpContext.Current.Server.MapPath("~/GetJpg/"), fileName);
                            //資料夾不存在的話創一個
                            if (!Directory.Exists(path))
                            {
                                Directory.CreateDirectory(path);
                            }
                            //有此檔名的話把他刪了
                            if (File.Exists(fileName))
                            {
                                File.Delete(fileName);
                            }
                            Image photo = Image.FromStream(photoFile.InputStream);
                            photo.Save(pathName, System.Drawing.Imaging.ImageFormat.Jpeg);

                        return 1;
                        }
                    
                }
            }
            return 2;
        }

        public int UserUpJpg(HttpPostedFileBase photoFile)
        {
            //如果有上傳成功
            if (photoFile != null)
            {
                //圖片結尾是否為gif|png|jpg|bmp
                if (CheckPhotoFormat(photoFile.FileName))
                {


                    //大小>0byte
                    if (photoFile.ContentLength > 0)
                    {
                        //檔案名
                        var fileName = "user.jpg";
                        //路徑
                        var path = Path.Combine(HttpContext.Current.Server.MapPath("~/images/"));
                        //路徑加檔案名
                        var pathName = Path.Combine(HttpContext.Current.Server.MapPath("~/images/"), fileName);
                        //資料夾不存在的話創一個
                        if (!Directory.Exists(path))
                        {
                            Directory.CreateDirectory(path);
                        }
                        //有此檔名的話把他刪了
                        if (File.Exists(fileName))
                        {
                            File.Delete(fileName);
                        }
                        Image photo = Image.FromStream(photoFile.InputStream);
                        photo.Save(pathName, System.Drawing.Imaging.ImageFormat.Jpeg);

                        return 1;
                    }

                }
            }
            return 2;
        }





        private int RedirectToAction(string v, string X)
        {
            throw new NotImplementedException();
        }

        private bool CheckPhotoFormat(string fileName)
        {
            bool flag = false;
            string fileExtension = Path.GetExtension(fileName).ToLower();
            string[] allowedExtensions = { ".jpg", ".jpeg", ".png", ".gif" };

            for (int i = 0; i < allowedExtensions.Length; i++)
            {
                if (allowedExtensions[i].ToString().Equals(fileExtension))
                {
                    flag = true;
                }
            }

            return flag;
        }




    }
}

        