using CodeHat.Feature.PageContent.Repositories;
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
        private readonly IImageCropRepository _imageCropRepository;

        public PageContentController(IImageCropRepository imageCropRepository)
        {
            _imageCropRepository = imageCropRepository;
        }
        public ActionResult ImageCrop() 
        {
            var model = _imageCropRepository.GetModel();
            return View(model); 
        }

        [HttpPost]

        public ActionResult UploadImage(string data)
        {
            return Json(new { results = "OK" }, JsonRequestBehavior.AllowGet);
        }
    }
}