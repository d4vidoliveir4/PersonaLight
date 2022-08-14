using Crud;
using Data.Repositorios;
using Dominio.Entidades;
using Dominio.Repositorios;
using System.Collections.Generic;

namespace PersonaLight.Models
{
    public class CadastroReserva : InternoModel<Reserva>
    {
        public CadastroReserva() { }

        public CadastroReserva(int id)
        {
            PreencherDadosAlteracao(id);
        }

        protected override IRepositorio<Reserva> Repositorio => new ReservaRepositorio();

        public IEnumerable<Orcamento> ListarOrcamentos()
        {
            return Consulta<Orcamento>.Obter(new OrcamentoRepositorio());
        }

        internal override void PreencherDadosAlteracao(int id)
        {
            var reserva = Consulta<Reserva>.Obter(new ReservaRepositorio(), id);

            Entidade = reserva ?? new Reserva();
        }
    }
}
