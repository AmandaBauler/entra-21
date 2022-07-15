using Entra21.BancoDadosAdo.net.Models;

namespace Entra21.BancoDadosAdo.net.Services
{
    internal interface ITipoPersonagemService
    {
        void Cadastrar(TipoPersonagem tipoPersonagem);
        List<TipoPersonagem> ObterTodos();
        void Apagar(int id);
        TipoPersonagem ObterPorId(int id);
        void Editar(TipoPersonagem tipoPersonagem);
    }
}
