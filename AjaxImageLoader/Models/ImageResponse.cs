using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AjaxImageLoader.Models
{
    public class ImageResponse
    {
        List<string> _imageList = new List<string>();

        public string Message { get; set; }
        public List<string> ImagesNameList { get { return _imageList; } }
    }
}