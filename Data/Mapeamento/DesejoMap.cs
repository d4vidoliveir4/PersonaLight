using Dominio.Entidades;
using Data.Mapeamento.ClassesPai;

namespace Data.Mapeamento
{
    class DesejoMap : Map<Desejo>
    {
        public DesejoMap()
        {
            Map(x => x.Descricao).Length(1000000);
            Map(x => x.Valor);
            Map(x => x.Ordem);
            Map(x => x.Realizado);
            Table("Desejo");
        }
    }
}