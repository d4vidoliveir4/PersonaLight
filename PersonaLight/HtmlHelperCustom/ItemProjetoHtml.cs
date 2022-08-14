using PersonaLight.Constantes;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace PersonaLight.HtmlHelperCustom
{
    public static class ItemProjetoHtml
    {
        public static IHtmlContent ItemProjeto(this IHtmlHelper htmlHelper, string titulo, string linkImagem, string texto, bool textoNaEsquerda = false)
        {
            var retorno = "<div class=\"projeto\">" +
                                "<h3 class=\"tituloProjeto\">" + titulo + "</h3>" +
                                "<div class=\"caixaProjeto\">" +
                                        (textoNaEsquerda?"": "<div class=\"imagemProjeto\"><img src=\"" + linkImagem + "\" width=100%></div>")+
                                        "<div class=\"" + (textoNaEsquerda ? "textoProjetoEsquerda" : "textoProjetoDireita") + "\">" +
                                            "<p>" + texto + "</p>" +
                                        "</div>" +
                                        (textoNaEsquerda ? "<div class=\"imagemProjeto\"><img src=\"" + linkImagem + "\" width=100%></div>" : "") +
                                        "</div></div>";

            return new HtmlString(retorno);
        }
    }
}