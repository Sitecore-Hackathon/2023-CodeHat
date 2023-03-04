using Sitecore.Mvc.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace CodeHat.Feature.GeneralContent.Sxa.Controllers
{
    public class ImageSxaController: SitecoreController
    {
        [HttpPost]

        public ActionResult UploadImage(string data)
        {
            return Json(new { results = "OK" }, JsonRequestBehavior.AllowGet);
        }
    }
}
