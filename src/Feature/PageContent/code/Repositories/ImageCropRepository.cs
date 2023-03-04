using CodeHat.Feature.PageContent.Models;
using Sitecore.Diagnostics;
using Sitecore.XA.Foundation.Mvc.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeHat.Feature.PageContent.Repositories
{
    public class ImageCropRepository: ModelRepository, IImageCropRepository 
    {
        public override IRenderingModelBase GetModel()
        {
            var model = new ImageCropModel();
            try
            {
                FillBaseProperties(model);
                FillCustomProperties(model);
            }
            catch (Exception ex)
            {
                Log.Error("image crop",ex, this);
            }
            return model;
        }

        private void FillCustomProperties(ImageCropModel model)
        {
            
        }
    }
}