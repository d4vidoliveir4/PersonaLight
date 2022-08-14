using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PersonaLight.HtmlHelperCustom
{
    public static class MenuSistemaHtml
    {
        public static IHtmlContent MenuSistema(this IHtmlHelper htmlHelper, string tituloPagina)
        {
            var retorno = "<head><link rel=\"stylesheet\" href=\"/css/sistema.css\" /></head><div id=\"titulo\"><a style=\"color:#671fcc;text-decoration:none;\" id=\"menu\" title=\"Menu\"><i class=\"fas fa-bars\"></i> " +
                tituloPagina + "</a></div><div id=\"menuLateral\" class=\"menuLateral\"><table class=\"tabelaLateral\"><tr><td class=\"topo\" style=\"text-align: center; padding: 15px;\"><img class=\"imgUsuari\" src=\"/assets/user.jpg\" alt=\"...\" style=\"width:90%; border-radius: 57%; text-align:center;\" /><p style = \"text-align:center;\" > D4vid Oliveir4<p></td></tr>" +
                                
                                htmlHelper.ItemMenuSistema("botaoDiario", "Diário", "/CadastroBlog/Diario") +
                                htmlHelper.ItemMenuSistema("botaoDesejos", "Desejos", "/CadastroDesejo") +
                                htmlHelper.ItemMenuSistema("botaoFinanceiro", "Financeiro", "/ControleFinanceiro/Movimento") +
                                htmlHelper.ItemMenuSistema("botaoGastoMes", "Gastos/Mês", "/ControleFinanceiro/Grafico") +
                                htmlHelper.ItemMenuSistema("botaoBlog", "Blog", "/CadastroBlog") +
                                htmlHelper.ItemMenuSistema("botaoOrcamento", "Orçamento", "/CadastroOrcamento") +
                                htmlHelper.ItemMenuSistema("botaoReserva", "Reserva", "/CadastroReserva") +
                                htmlHelper.ItemMenuSistema("botaoDadosMedicos", "Saúde", "/CadastroDadosMedicos") +
                                htmlHelper.ItemMenuSistema("botaoUsuarios", "Usuário", "/CadastroUsuario") +
                                htmlHelper.ItemMenuSistema("botaoSair", "Sair", "/Login/Deslogar") +
                        "</table></div><script>$(\"#menu\").click(function(){$(\"#menuLateral\").toggle();});</script>";
            return new HtmlString(retorno);
        }
    }
}
