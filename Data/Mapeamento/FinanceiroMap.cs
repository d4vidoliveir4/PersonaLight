using Dominio.Entidades;
using Data.Mapeamento.ClassesPai;

namespace Data.Mapeamento
{
    class FinanceiroMap : Map<Financeiro>
    {
        public FinanceiroMap()
        {
            Map(x => x.Data);
            Map(x => x.Descricao).Length(1000000);
            References(x => x.Orcamento).Not.LazyLoad().Cascade.None();
            Map(x => x.Valor);
            Map(x => x.Tipo);
            Table("Financeiro");
        }
    }
}