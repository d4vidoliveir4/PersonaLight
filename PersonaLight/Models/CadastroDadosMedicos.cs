using Crud;
using Data.Repositorios;
using Dominio.Entidades;
using Dominio.Repositorios;

namespace PersonaLight.Models
{
    public class CadastroDadosMedicos : InternoModel<DadosMedicos>
    {
        public CadastroDadosMedicos() { }

        public CadastroDadosMedicos(int id)
        {
            PreencherDadosAlteracao(id);
        }

        protected override IRepositorio<DadosMedicos> Repositorio => new DadosMedicosRepositorio();

        internal override void PreencherDadosAlteracao(int id)
        {
            var reserva = Consulta<DadosMedicos>.Obter(new DadosMedicosRepositorio(), id);

            Entidade = reserva ?? new DadosMedicos();
        }
    }
}
