using CodeHat.Feature.GeneralContent.Sxa.Models;
using CodeHat.Feature.GeneralContent.Sxa.Repositories;
using Sitecore.XA.Foundation.Mvc.Controllers;
using System.Web.Mvc;

namespace CodeHat.Feature.GeneralContent.Sxa.Controllers
{
    public class PageContentController : StandardController
    {
        private readonly IImageCropRepository _imageCropRepository;

        public PageContentController(IImageCropRepository imageCropRepository)
        {
            _imageCropRepository = imageCropRepository;
        }

        public ActionResult ImageCrop()
        {
            var model = (ImageCropModel)_imageCropRepository.GetModel();
            return PartialView(model);
        }

        [HttpPost]
        public ActionResult UploadAvatar(string data)
        {
            return Json(new { data });
        }
    }
}
