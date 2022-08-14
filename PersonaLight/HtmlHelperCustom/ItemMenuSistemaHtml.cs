using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PersonaLight.HtmlHelperCustom
{
    public static class ItemMenuSistemaHtml
    {
        public static IHtmlContent ItemMenuSistema(this IHtmlHelper htmlHelper, string id, string texto, string telaDestino)
        {
            var retorno = "<tr class=\"botaoMenuLateral\"><td class=\"tdMenuLateral\">" + htmlHelper.Botao(id, texto, "btn-menuLateral", telaDestino) + "</td></tr>";
            return new HtmlString(retorno);
        }
    }
}
