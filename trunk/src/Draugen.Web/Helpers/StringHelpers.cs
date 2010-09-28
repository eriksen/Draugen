using System.Web.Mvc;

namespace Draugen.Helpers
{
    public static class StringHelpers
    {
        public static string KommentarExtract(this HtmlHelper helper, string kommentar)
        {
            return kommentar;
            if (kommentar.Length <= 100) { return kommentar;  }
            return kommentar.Substring(0, 97) + "...";
        }
    }
}