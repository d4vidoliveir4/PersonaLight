using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PersonaLight.HtmlHelperCustom
{
    public static class BotaoSocialHtml
    {
        public static IHtmlContent BotaoSocial(this IHtmlHelper htmlHelper, string link, string icone)
        {
            var retorno = "<li class=\"list-inline-item\"><a class=\"social-link rounded-circle text-white mr-3\" href=\"" + link + "\" target=\"_blank\"><i class=\"" + icone + "\"></i></a></li>";
            return new HtmlString(retorno);
        }
    }
}