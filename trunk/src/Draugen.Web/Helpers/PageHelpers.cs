using System.Web.Mvc;
using Draugen.Services.Dtos;

namespace Draugen.Helpers
{
    public static class PageHelpers
    {
        public static MvcHtmlString First(this HtmlHelper helper, PageInfoDto pageInfo)
        {
            return MvcHtmlString.Create("1");
        } 
    }
}