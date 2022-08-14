using Crud;
using Data.Repositorios;
using Dominio.Entidades;
using Dominio.Repositorios;
using System.Collections.Generic;
using System.Linq;

namespace PersonaLight.Models
{
    public class CadastroDesejo : InternoModel<Desejo>
    {
        public CadastroDesejo() { }

        public CadastroDesejo(int id)
        {
            PreencherDadosAlteracao(id);
        }

        protected override IRepositorio<Desejo> Repositorio => new DesejoRepositorio();

        internal override void PreencherDadosAlteracao(int id)
        {
            var reserva = Consulta<Desejo>.Obter(new DesejoRepositorio(), id);

            Entidade = reserva ?? new Desejo();
        }

        public override IEnumerable<Desejo> ListarEntidades()
        {
            return base.ListarEntidades().OrderBy(o=>o.Realizado).ThenBy(o => o.Ordem);
        }
    }
}
