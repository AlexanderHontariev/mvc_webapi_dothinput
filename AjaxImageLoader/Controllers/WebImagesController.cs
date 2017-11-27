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

        [HttpPut]
        public void CreateImage (Image img)
        {

        }

        [HttpPost]
        public void PostExample (Person p)
        {

        }
    }
}
