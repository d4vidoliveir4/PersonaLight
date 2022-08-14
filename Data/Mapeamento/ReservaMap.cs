using Dominio.Entidades;
using Data.Mapeamento.ClassesPai;

namespace Data.Mapeamento
{
    class ReservaMap : Map<Reserva>
    {
        public ReservaMap()
        {
            Map(x => x.Descricao).Length(1000000);
            Map(x => x.Referencia).Length(1000000);
            References(x => x.Orcamento).Not.LazyLoad().Cascade.None();
            Map(x => x.ValorAtual);
            Map(x => x.ValorObjetivo);
            Map(x => x.Prazo);
            Table("Reserva");
        }
    }
}