using System;
using System.Text.RegularExpressions;

namespace Draugen.Data.Import.Builders
{
    public static class MatchGroupExtender
    {
        public static string AsString(this Group value)
        {
            if (value.Length == 0) return "";
            var text = value.ToString().Trim(new char[] { ' ', '\''});
            if (text.Length == 0) return "";
            text = text.Substring(0, 1).ToUpper() + text.Substring(1);
            return text;
        }

        public static int AsInt(this Group value)
        {
            return Convert.ToInt32(value.ToString());
        }

        public static string AsStatus(this Group value)
        {
            switch (value.AsInt())
            {
                case 2:
                    return "Draug";
                case 3:
                    return "Stordraug";
                default:
                    return "Draugling";
            }
        }

        public static double AsKilo(this Group value)
        {
            var grams = Convert.ToDouble(value.ToString());
            return grams/1000;
        }

        public static double AsCentimeters(this Group value)
        {
            var millimeter = Convert.ToDouble(value.ToString());
            return millimeter/10;
        }

        public static DateTime AsDate(this Group value)
        {
            return Convert.ToDateTime(value.AsString());
        }
    }
}