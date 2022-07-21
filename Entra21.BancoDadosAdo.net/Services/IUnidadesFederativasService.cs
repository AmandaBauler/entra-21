using Entra21.BancoDadosAdo.net.Models;

namespace Entra21.BancoDadosAdo.net.Services
{
    internal interface IUnidadesFederativasService
    {
        List<UnidadesFederativas> ObterTodos();
        UnidadesFederativas ObterPorId(int id);
        void Cadastrar(UnidadesFederativas unidadeFederativa);
        void Apagar(int id);
        void Editar(UnidadesFederativas unidadeFederativa);

    }
}
