using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AjaxImageLoader.Models
{
    public class Paging
    {
        public int CurentPage { get; set; }
        public int ItemsPerPage { get; set; }
        public int TotalPages { get; set; }

        public Paging() { }

        public Paging(int curentPage, int itemsPerPage, int allItems)
        {
            ItemsPerPage = itemsPerPage;
            TotalPages = (int)Math.Ceiling((decimal)allItems / (decimal)itemsPerPage);
            CurentPage = curentPage;
        }
    }
}