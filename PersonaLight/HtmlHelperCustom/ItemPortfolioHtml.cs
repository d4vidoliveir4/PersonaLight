using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PersonaLight.HtmlHelperCustom
{
    public static class ItemPortfolioHtml
    {
        public static IHtmlContent ItemPortfolio(this IHtmlHelper htmlHelper, string link, string titulo, string descricao, string linkImagem, string altImagem)
        {
            var retorno = "<div class=\"col-lg-6\"><a class=\"portfolio-item\" href=\"" + link + "\"> <div class=\"caption\"><div class=\"caption-content\"><div class=\"h2\">" +
                titulo + "</div><p class=\"mb-0\">" +
                descricao + "</p></div></div><img class=\"img-fluid\" src=\"" +
                linkImagem + "\" alt=\"" + altImagem + "\" /></a></div>";
            return new HtmlString(retorno);
        }
    }
}