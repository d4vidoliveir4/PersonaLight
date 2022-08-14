using Dominio.Entidades;
using Data.Mapeamento.ClassesPai;

namespace Data.Mapeamento
{
    class PostagemMap : Map<Postagem>
    {
        public PostagemMap()
        {
            Map(x => x.Titulo);
            Map(x => x.Conteudo).Length(1000000);
            Map(x => x.DataPublicacao);
            Map(x => x.Tags);
            Map(x => x.Publicado);
            Map(x => x.DataAlteracao);
            Table("Postagem");
        }
    }
}