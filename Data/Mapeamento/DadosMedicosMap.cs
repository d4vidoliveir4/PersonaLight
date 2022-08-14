using Dominio.Entidades;
using Data.Mapeamento.ClassesPai;

namespace Data.Mapeamento
{
    class DadosMedicosMap : Map<DadosMedicos>
    {
        public DadosMedicosMap()
        {
            Map(x => x.ComoMeSinto);
            Map(x => x.Pressao);
            Map(x => x.Glicose);
            Map(x => x.Peso);
            Map(x => x.Temperatura);
            Map(x => x.Data);
            Table("DadosMedicos");
        }
    }
}