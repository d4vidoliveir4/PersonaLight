using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PersonaLight.HtmlHelperCustom
{
    public static class ItemMenuSiteHtml
    {
        public static IHtmlContent ItemMenuSite(this IHtmlHelper htmlHelper, string link, string texto)
        {
            var retorno = "<li class=\"sidebar-nav-item\"><a href=\"" + link + "\">" + texto + "</a></li>";
            return new HtmlString(retorno);
        }
    }
}