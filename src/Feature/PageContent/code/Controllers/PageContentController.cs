using Sitecore.XA.Foundation.Mvc.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeHat.Feature.PageContent.Controllers
{
    public class PageContentController: StandardController
    {
        public ActionResult ImageCrop() 
        { 
            return View(); 
        }

        [HttpPost]

        public ActionResult UploadImage(string data)
        {
            return Json(new { results = "OK" }, JsonRequestBehavior.AllowGet);
        }
    }
}