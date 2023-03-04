using Sitecore.Pipelines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Routing;

namespace CodeHat.Feature.GeneralContent.Sxa.Pipelines
{
    public class RegisterWebApiRoutes
    {
#pragma warning disable RECS0154 // Parameter is never used
        public void Process(PipelineArgs args)
#pragma warning restore RECS0154 // Parameter is never used
        {
            RouteTable.Routes.MapRoute("uploadimage", "api/{controller}/{action}",
                new { controller = "ImageSxa", action = "UploadImage" });            

        }
    }
}
