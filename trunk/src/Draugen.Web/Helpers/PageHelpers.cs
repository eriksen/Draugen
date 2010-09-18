using System.Web.Mvc;
using Draugen.Services.Dtos;

namespace Draugen.Helpers
{
    public static class PageHelpers
    {
        public static MvcHtmlString PageFirstLink(this HtmlHelper helper, PageInfoDto pageInfo)
        {
            return MvcHtmlString.Create("Første side");
        }

        public static MvcHtmlString PageLastLink(this HtmlHelper helper, PageInfoDto pageInfo)
        {
            return MvcHtmlString.Create("Siste side");
        }

        public static MvcHtmlString PageNextLink(this HtmlHelper helper, PageInfoDto pageInfo)
        {
            return MvcHtmlString.Create("Neste side");
        }

        public static MvcHtmlString PagePreviousLink(this HtmlHelper helper, PageInfoDto pageInfo)
        {
            return MvcHtmlString.Create("Forrige side");
        }

        public static MvcHtmlString PageIndexLink(this HtmlHelper helper, PageInfoDto pageInfo, int currentIndex)
        {
            if(currentIndex == pageInfo.Index)
            {
                return MvcHtmlString.Create("<strong>" + currentIndex + "</strong>");
            }
            return MvcHtmlString.Create(currentIndex.ToString());
        }
    }
}