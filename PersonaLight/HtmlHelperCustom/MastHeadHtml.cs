using PersonaLight.Constantes;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PersonaLight.HtmlHelperCustom
{
    public static class MastHeadHtml
    {
        public static IHtmlContent MastHead(this IHtmlHelper htmlHelper, bool botaoProjetos = false, bool pequeno = false)
        {
            var retorno = "<header class=\"" + (pequeno ? "mastheadBlog" : "masthead") + " d-flex align-items-center\"><div class=\"container px-4 px-lg-5 text-center\">" +
                (pequeno?"": "<h1 class=\"mb-1\">" + DadosSite.SubTitulo + "</h1>") +
                "<h3 class=\"mb-5\"><em>" + (pequeno? DadosSite.SubTitulo:DadosSite.Descricao) + "</em></h3>" +
                (botaoProjetos ? "<br /><a class=\"btn btn-primary btn-xl\" href=\"" + Urls.PaginaProjetos + "\" style=\"margin-bottom:-20%;\">Conheça os projetos!</a>" : "") +
                "</div></header>";
            return new HtmlString(retorno);
        }
    }
}