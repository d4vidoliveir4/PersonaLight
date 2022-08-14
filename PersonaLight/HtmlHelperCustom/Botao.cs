using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PersonaLight.HtmlHelperCustom
{
    public static class BotaoHtml
    {
        public static IHtmlContent Botao(this IHtmlHelper htmlHelper, string id, string texto, string classes = null, string telaDestino = null, string tipo = "button", string titulo = "")
        {
            var retorno = $"<button id=\"{id}\"type=\"{tipo}\" class=\"{classes ?? string.Empty}\" title=\"{titulo}\">{texto}</button>";

            if (!string.IsNullOrEmpty(telaDestino))
                retorno += "<script> $(\"#" + id + "\").click(function() {location.replace('" + telaDestino + "');});</script> ";

            return new HtmlString(retorno);
        }
    }
}