using PersonaLight.Constantes;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PersonaLight.HtmlHelperCustom
{
    public static class FooterSiteHtml
    {
        public static IHtmlContent FooterSite(this IHtmlHelper htmlHelper)
        {
            var retorno = "<footer class=\"footer text-center\" id=\"contato\"><div class=\"container px-4 px-lg-5\"><ul class=\"list-inline mb-5\">" +
                                htmlHelper.BotaoSocial(Urls.Github, "fab fa-github") +
                                htmlHelper.BotaoSocial(Urls.Instagram, "fab fa-instagram") +
                                htmlHelper.BotaoSocial(Urls.Email, "fas fa-envelope") +
                                "</ul>" +
                                htmlHelper.CopyRight() +
                                "</div></footer>";
            return new HtmlString(retorno);
        }
    }
}