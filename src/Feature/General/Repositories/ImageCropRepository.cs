using CodeHat.Feature.GeneralContent.Sxa.Models;
using Sitecore.Diagnostics;
using Sitecore.XA.Foundation.Mvc.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeHat.Feature.GeneralContent.Sxa.Repositories
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
            catch(Exception ex)  
            {
                Log.Error("image crop", ex, this);
            }

            return model;
        }

        public void SaveImageCrop(string data, string dataSourceId)
        {
            
        }

        private void FillCustomProperties(ImageCropModel model)
        {
         
        }
    }
}
