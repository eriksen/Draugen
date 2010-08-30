using System.Web.Mvc;

namespace Draugen.Configuration
{
    public class DraugenWebFormViewEngine : WebFormViewEngine
    {
        public DraugenWebFormViewEngine()
        {
            PartialViewLocationFormats = new []   {
                                                      "~/Views/Shared/{0}.ascx",
                                                  };

        }
    }
}