using System.Web.Mvc;

namespace Draugen.Helpers
{
    public static class ImageHelpers
    {
        public static MvcHtmlString Image(this HtmlHelper helper, string bilde)
        {
            var image = new TagBuilder("img");
            image.MergeAttribute("src", bilde);
            image.MergeAttribute("alt", bilde);
            image.MergeAttribute("height", "100px");
            image.MergeAttribute("width", "100px");
            return MvcHtmlString.Create(image.ToString(TagRenderMode.SelfClosing));
        }
    }
}