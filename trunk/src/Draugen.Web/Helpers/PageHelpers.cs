using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using Draugen.Services.Dtos;

namespace Draugen.Helpers
{
    public static class PageHelpers
    {
        private const int Cutoff = 5;

        public static MvcHtmlString PageFirstLink(this HtmlHelper helper, PageInfoDto pageInfo)
        {
            return pageInfo.Index <= Cutoff + 1 ? MvcHtmlString.Empty : CreateLink(helper, 1, "1", "");
        }

        public static MvcHtmlString PageLastLink(this HtmlHelper helper, PageInfoDto pageInfo)
        {
            return pageInfo.Index >= pageInfo.TotalPages - Cutoff - 1 ? MvcHtmlString.Empty : CreateLink(helper, pageInfo.TotalPages, pageInfo.TotalPages.ToString(), "");
        }

        public static MvcHtmlString PageNextLink(this HtmlHelper helper, PageInfoDto pageInfo)
        {
            return pageInfo.Index == pageInfo.TotalPages ? MvcHtmlString.Empty : CreateLink(helper, pageInfo.Index+1,"Next", "");
        }

        public static MvcHtmlString PagePreviousLink(this HtmlHelper helper, PageInfoDto pageInfo)
        {
            return pageInfo.Index == 1 ? MvcHtmlString.Empty : CreateLink(helper, pageInfo.Index - 1, "Previous", "");
        }

        public static MvcHtmlString PageIndexLink(this HtmlHelper helper, PageInfoDto pageInfo, int currentIndex)
        {
            if (currentIndex < pageInfo.Index - Cutoff || currentIndex > pageInfo.Index + Cutoff) 
            {
                return MvcHtmlString.Empty; 
            }
            if (currentIndex == pageInfo.Index - Cutoff && currentIndex > 2)
            {
                return CreateLink(helper, currentIndex, "...", "");
            }
            if (currentIndex == pageInfo.Index + Cutoff && currentIndex < pageInfo.TotalPages - 1)
            {
                return CreateLink(helper, currentIndex, "...", "");
            }
            if (currentIndex == pageInfo.Index)
            {
                return CreateStrongLink(currentIndex, helper);
            }
            return CreateLink(helper, currentIndex, currentIndex.ToString(), "");
        }

        private static MvcHtmlString CreateStrongLink(int currentIndex, HtmlHelper helper)
        {
            var tag = new TagBuilder("strong")
                          {
                              InnerHtml = CreateLink(helper, currentIndex, currentIndex.ToString(), "").ToString()
                          };
            return MvcHtmlString.Create(tag.ToString());
        }

        private static MvcHtmlString CreateLink(HtmlHelper helper, int pageIndex, string linkText, string title)
        {
            var routeValues = helper.ViewContext.RouteData.Values;
            routeValues["page"] = pageIndex.ToString();
            return helper.RouteLink(linkText, routeValues, new Dictionary<string, object> { {"title", title}, {"class", "pagelink"} });
        }

    }
}