using PersonaLight.Constantes;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace PersonaLight.HtmlHelperCustom
{
    public static class CopyRightHtml
    {
        public static IHtmlContent CopyRight(this IHtmlHelper htmlHelper)
        {
            var retorno = "<a href=\"" + Urls.Dominio + "\" class=\"text-muted small mb-0\" style=\"text-decoration: none; font-size: 1.5rem;\">Copyright &copy; David Oliveira " + DateTime.Now.Year + "</a>";
            return new HtmlString(retorno);
        }
    }
}