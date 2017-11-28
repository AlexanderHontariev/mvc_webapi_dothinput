using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using AjaxImageLoader.Models;
using System.IO;

namespace AjaxImageLoader.Controllers
{
    public class WebController : ApiController
    {
        ImageList _repo = ImageList.Curent;
        int _itemsPerPage = 4;

        [HttpGet]
        public ImageModel GetAllImages(int page)
        {
            ImageModel model = new ImageModel {
                Paging = new Paging(page, _itemsPerPage, _repo.Length),
                Images = _repo.GetInterval((page - 1) * _itemsPerPage, _itemsPerPage)
            };
            return model;
        }

        [HttpDelete]
        public void DeleteImage(int id)
        {
            Image img = _repo.RemoveImage(id);
            if (img != null)
            {
                var imgPath = Path.Combine(HttpContext.Current.Request.MapPath("~/Images"), img.ImageName);
                if (File.Exists(imgPath))
                    File.Delete(imgPath);
            }
        }

        [HttpPost]
        public void CreateImage()
        {
            var files = HttpContext.Current.Request.Files;
            for (int i = 0; i < files.Count; i++)
            {
                HttpPostedFile file = files[i];
                int contentLength = file.ContentLength;
                string contentType = file.ContentType;

                if (new string[] { "image/jpeg", "image/png", "image/gif" }.Any(ct => ct == contentType) && contentLength <= 900000)
                {
                    file.SaveAs(Path.Combine(GetImageFolderPath(), file.FileName));
                } else
                {

                }
            }
        }

        private string GetImageFolderPath()
        {
            return HttpContext.Current.Request.MapPath("~/Images");
        }
    }
}
