using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosListas.Exercicio01Triangulo
{
    internal class TrianguloController
    {
        private TrianguloServico trianguloServico = new TrianguloServico();

        public void GerenciarMenu()
        {
            int codigo = 0;

            while (codigo != 3)
            {
                //codigo = ApresentarSolicitarMenu();

                if (codigo == 1)
                {
                    //ApresentarTriangulo();
                }
                else if (codigo == 2)
                {
                    //Cadastrar();
                }

            }
        }
        private void ApresentarTriangulo()
        {

        }
        private void Apagar()
        {

        }
        private void Editar()
        {

        }
        public int SolicitarMenuTriangulo()
        {
            return 0; 
        }
        private int SolicitarCodigo()
        {
            return 0;
        }
        private void Cadastrar()
        {

        }

    }
}
