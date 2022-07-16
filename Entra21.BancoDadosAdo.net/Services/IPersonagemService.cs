using Entra21.BancoDadosAdo.net.Models;

namespace Entra21.BancoDadosAdo.net.Services
{
    internal interface IPersonagemService
    {
        List<Personagem> ObterTodos();
        Personagem ObterPorId(int id);
        void Cadastrar(Personagem personagem);
        void Editar(Personagem personagem);
        void Apagar(int id);
    }
}