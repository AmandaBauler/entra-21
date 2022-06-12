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
            CadastrarTriangulo();
            ApresentarListaDeTriangulos();
            ApresentarTriangulo();
        }
        public void CadastrarTriangulo()
        {
            Console.WriteLine("Lado1: ");
            int lado1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lado2: ");
            int lado2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lado3: ");
            int lado3 = Convert.ToInt32(Console.ReadLine());

            var cadastro = trianguloServico.AdicionarTriangulo(lado1, lado2, lado3);

            if (cadastro == false)
            {
                Console.WriteLine("Erro ao tentar cadastrar o triangulo.");
            }
            else
            {
                Console.WriteLine("Triangulo cadastrado.");
            }
        }
        public void ApresentarListaDeTriangulos()
        {
            var triangulos = trianguloServico.ObterTodos();

            if (triangulos.Count == 0)
            {
                Console.WriteLine("Nenhum triangulo cadastrado até o momento.");

                return;
            }

            Console.WriteLine("Lista de triangulos cadastrados: ");
            for (int i = 0; i < triangulos.Count; i++)
            {
                var trianguloAtual = triangulos[i];

                Console.WriteLine($"Código: {trianguloAtual.Codigo} \nLado1: {trianguloAtual.Lado1} \nLado2: {trianguloAtual.Lado2} \nLado3: {trianguloAtual.Lado3}");
            }
        }
        private void ApresentarTriangulo()
        {
            ApresentarListaDeTriangulos();

            Console.Write("Digite o código do triângulo desejado: ");
            var codigo = Convert.ToInt32(Console.ReadLine());

            var triangulo = trianguloServico.ObterPorCodigo(codigo);

            if (triangulo == null)
            {
                Console.WriteLine("Triangulo inexistente.");

                return;
            }

            Console.WriteLine(@$"Código: {triangulo.Codigo}
Lado 1: {triangulo.Lado1}
Lado 2: {triangulo.Lado2}
Lado 3: {triangulo.Lado3}");


        }





    }
}
