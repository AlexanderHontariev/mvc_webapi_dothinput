using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AjaxImageLoader.Models;

namespace AjaxImageLoader.Controllers
{
    public class HomeController : Controller
    {
        ImageList _repo = ImageList.Curent;

        public ActionResult Index()
        {
            return View(_repo.GetAll());
        }
    }
}