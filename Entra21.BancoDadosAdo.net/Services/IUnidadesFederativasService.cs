using Entra21.BancoDadosAdo.net.Models;

namespace Entra21.BancoDadosAdo.net.Services
{
    internal interface IUnidadesFederativasService
    {
        List<UnidadeFederativa> ObterTodos();
        UnidadeFederativa ObterPorId(int id);
        void Cadastrar(UnidadeFederativa unidadeFederativa);
        void Apagar(int id);
        void Editar(UnidadeFederativa unidadeFederativa);

    }
}
