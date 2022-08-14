using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PersonaLight.HtmlHelperCustom
{
    public static class SummernoteHtml
    {
        public static IHtmlContent Summernote(this IHtmlHelper htmlHelper)
        {
            var retorno = "<link href=\"/lib/summernote-0.8.18-dist/summernote.css\" rel=\"stylesheet\">";
            retorno += "<script src=\"/lib/summernote-0.8.18-dist/summernote.js\"></script><script>$(document).ready(function () {$('.textarea-editor').summernote({height: 500,minHeight: null,maxHeight: null,focus: true});});</script> ";

            return new HtmlString(retorno);
        }
    }
}