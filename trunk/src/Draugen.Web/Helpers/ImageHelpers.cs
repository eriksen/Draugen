using System;
using System.Web.Mvc;

namespace Draugen.Helpers
{
    public static class ImageHelpers
    {
        public static MvcHtmlString Image(this HtmlHelper helper, string bilde)
        {
            //var image = new TagBuilder("img");
            //image.MergeAttribute("src", "~/Content/Images/" + bilde.Navn);
            //image.MergeAttribute("alt", bilde.Alt);
            //return MvcHtmlString.Create(image.ToString(TagRenderMode.SelfClosing));
            throw new NotImplementedException();
        }
    }
}