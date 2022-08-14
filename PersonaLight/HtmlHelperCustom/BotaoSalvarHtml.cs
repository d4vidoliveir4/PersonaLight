using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PersonaLight.HtmlHelperCustom
{
    public static class BotaoSalvarHtml
    {
        public static IHtmlContent BotaoSalvar(this IHtmlHelper htmlHelper, bool excluir)
        {
            var retorno = "<div class=\"botoes\">";

            if (excluir)
                retorno += "<button type=\"button\" class=\"btnPadrao marginBtnPadrao\" data-toggle=\"modal\" data-target=\"#confirm\">Excluir</button>"+
                           "<div class=\"modal fade\" id=\"confirm\" role=\"dialog\">"+
                           "<div class=\"modal-dialog modal-md\"><div class=\"modal-content\"><div class=\"modal-body\" style=\"text-align:left;\">"+
                           "<p>Deseja realmente excluir esse registro?</p>"+
                           "</div><div class=\"modal-footer\"><button type=\"button\" data-dismiss=\"modal\" class=\"btnPadrao\" id=\"excluir\">Excluir</button>"+
                           "<button type=\"button\" data-dismiss=\"modal\" class=\"btnPadrao\">Cancelar</button></div></div></div></div>";

            retorno += htmlHelper.Botao("salvar", "Salvar", "btnPadrao marginBtnPadrao", tipo: "submit", titulo: "Salvar")+"</div>";
            
            return new HtmlString(retorno);
        }
    }
}