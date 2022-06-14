namespace Entra21.ExerciciosListas.Exercicio01Triangulo
{
    internal class TrianguloController
    {
        private TrianguloServico trianguloServico = new TrianguloServico();

        public void GerenciarMenu()
        {
            var codigo = 0;

            while (codigo != 6)
            {
                Console.Clear();

                codigo = ApresentarMenuTriangulo();

                if (codigo == 1)
                {
                    CadastrarTriangulo();
                }
                else if (codigo == 2)
                {
                    EditarTriangulo();
                }
                else if (codigo == 3)
                {
                    ApagarTriangulo();
                }
                else if (codigo == 4)
                {
                    ApresentarTodosTriangulos();
                }
                else if (codigo == 5)
                {
                    ApresentarTriangulo();
                }

                Console.WriteLine("\n\nAperte alguma tecla para continuar...");
                Console.ReadKey();
            }

        }
        private int ApresentarMenuTriangulo()
        {
            Console.WriteLine(@"  MENU
1- CADASTRAR
2- EDITAR
3- APAGAR
4- APRESENTAR TODOS OS TRIANGULOS CADASTRADOS
5- APRESENTAR PRODUTO DESEJADO
6- SAIR");
            var numeroEscolhido = SolicitarCodigo();

            return numeroEscolhido;
        }
        private int SolicitarCodigo()
        {
            var codigo = 0;

            while (codigo < 1 || codigo > 6)
            {
                try
                {
                    Console.WriteLine("Digite o código: ");
                    codigo = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Digite um menu valido");
                }
            }

            return codigo;
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
        private void EditarTriangulo()
        {
            ApresentarTodosTriangulos();

            Console.WriteLine("Informe o código do triangulo para editar: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o tamanho do Lado 1: ");
            int lado1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o tamanho do Lado 2: ");
            int lado2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o tamanho do Lado 3: ");
            int lado3 = Convert.ToInt32(Console.ReadLine());

            var alterou = trianguloServico.EditarTriangulo(codigo, lado1, lado2, lado3);

            if (alterou == false)
            {
                Console.WriteLine("Código digitado não extiste.");
            }
            else
            {
                Console.WriteLine("Codigo alterado com sucesso.");
            }

        }
        private void ApagarTriangulo()
        {
            ApresentarTodosTriangulos();

            Console.WriteLine("Informe o código do triangulo que deseja apagar: ");
            var codigo = Convert.ToInt32(Console.ReadLine());

            var codigoApagado = trianguloServico.ApagarTriangulo(codigo);

            if (codigoApagado == false)
            {
                Console.WriteLine("Código informado não existe.");
            }
            else
            {
                Console.WriteLine("O triangulo foi apagado com sucesso.");
            }

        }
        public void ApresentarTodosTriangulos()
        {
            var triangulos = trianguloServico.ObterTodos();

            if (triangulos.Count == 0)
            {
                Console.WriteLine("Nenhum triangulo cadastrado.");
            }

            Console.WriteLine("Lista de triangulos cadastrados: ");

            for (var i = 0; i < triangulos.Count; i++)
            {
                var trianguloAtual = triangulos[i];

                Console.WriteLine($"Código {trianguloAtual.Codigo}");
            }
        }
        private void ApresentarTriangulo()
        {
            ApresentarTodosTriangulos();

            Console.WriteLine("Código do tringulo que deseja visualizar: ");
            var codigo = Convert.ToInt32(Console.ReadLine());

            var triangulo = trianguloServico.ObterPorCodigo(codigo);

            if (triangulo == null)
            {
                Console.WriteLine("Esse triangulo não existe");
            }

            Console.WriteLine(@$"Código: {triangulo.Codigo}
Lado 1: {triangulo.Lado1}
Lado 2: {triangulo.Lado2}
Lado 3: {triangulo.Lado3}");

        }


    }
}
