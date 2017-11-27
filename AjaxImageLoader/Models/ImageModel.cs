using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AjaxImageLoader.Models
{
    public class ImageModel
    {
        public Paging Paging { get; set; }
        public IEnumerable<Image> Images { get; set; }
    }
}