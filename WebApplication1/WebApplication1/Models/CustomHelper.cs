using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Models
{
    public static class CustomHelper
    {
        public static IHtmlString Mytax(string txt)
        {
            string ans = "<img src='" + txt + "' alt='no data'>";
            return new MvcHtmlString(ans);
        }

        public static IHtmlString my(this HtmlHelper helper, string txt)
        {
            string ans = "<img src='" + txt + "' alt='no data'>";
            return new MvcHtmlString(ans);
        }

        public static IHtmlString tax(this HtmlHelper helper, string txt)
        {
            TagBuilder t = new TagBuilder("img");
            t.Attributes.Add("src", txt);
            t.Attributes.Add("alt", "no data");
            return new MvcHtmlString(t.ToString());
        }
    }
}