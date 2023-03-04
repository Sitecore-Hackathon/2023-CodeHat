using Sitecore.XA.Foundation.Mvc.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeHat.Feature.GeneralContent.Sxa.Repositories
{
    public interface IImageCropRepository: IModelRepository
    {
        void SaveImageCrop(string data, string dataSourceId);
    }
}
