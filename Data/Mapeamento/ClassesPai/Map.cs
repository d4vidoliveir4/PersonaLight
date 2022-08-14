using Dominio.Entidades.ClassesPai;
using FluentNHibernate.Mapping;

namespace Data.Mapeamento.ClassesPai
{
    class Map<T> : ClassMap<T>
        where T : Entidade
    {
        public Map()
        {
            Id(x => x.Id);
        }
    }
}