using PersonaLight.Constantes;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PersonaLight.HtmlHelperCustom
{
    public static class MenuSiteHtml
    {
        public static IHtmlContent MenuSite(this IHtmlHelper htmlHelper)
        {
            var retorno = "<div class=\"cabecalho\"><a class=\"tituloSite\" href=\"" + Urls.Dominio+"\">"+DadosSite.Titulo + "</a>" +
                          "<a class=\"botaoMenu rounded\" id=\"botaoMenu\"><i class=\"fas fa-bars\"></i> Menu</a></div>" +
                          "<nav id=\"menuLateral\"><ul class=\"sidebar-nav\">" +
                                htmlHelper.ItemMenuSite(Urls.Dominio, "Inicio") +
                                htmlHelper.ItemMenuSite(Urls.PaginaProjetos, "Projetos") +
                                htmlHelper.ItemMenuSite(Urls.Blog, "Blog") +
                                htmlHelper.ItemMenuSite(Urls.Email, "Contato") +
                                htmlHelper.ItemMenuSite(Urls.ContatoHome, "Destaques") +
                                htmlHelper.ItemMenuSite(Urls.Github, "GitHub") +
                                htmlHelper.ItemMenuSite(Urls.Twitch, "Twitch") +
                                htmlHelper.ItemMenuSite(Urls.Deviantart, "DeviantArt") +
                                "</ul></nav>";

            return new HtmlString(retorno);
        }
    }
}