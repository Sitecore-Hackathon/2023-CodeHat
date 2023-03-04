using Sitecore.Pipelines;
using System.Web.Mvc;
using System.Web.Routing;

namespace CodeHat.Feature.PageContent.Pipelines
{
    public class RegisterWebApiRoutes
    {
#pragma warning disable RECS0154 // Parameter is never used
        public void Process(PipelineArgs args)
#pragma warning restore RECS0154 // Parameter is never used
        {
            RouteTable.Routes.MapRoute("uploadimage", "api/{controller}/{action}",
                new { controller = "PageContent", action = "UploadImage" });

        }
    }
}