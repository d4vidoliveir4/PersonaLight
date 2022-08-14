using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PersonaLight.HtmlHelperCustom
{
    public static class BotoesCrudHtml
    {
        public static IHtmlContent BotoesCrud(this IHtmlHelper htmlHelper)
        {
            var retorno = "<div class=\"botoes\">" + htmlHelper.Botao("incluir", "Incluir", "btnPadrao marginBtnPadrao", titulo:"Incluir");

            retorno += "</div>";

            return new HtmlString(retorno);
        }
    }
}
