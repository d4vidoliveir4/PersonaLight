using Dominio.Entidades;
using Data.Mapeamento.ClassesPai;

namespace Data.Mapeamento
{
    class OrcamentoMap : Map<Orcamento>
    {
        public OrcamentoMap()
        {
            Map(x => x.Descricao);
            Map(x => x.Valor);
            Table("Orcamento");
        }
    }
}