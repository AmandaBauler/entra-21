namespace Entra21.ExemplosListas
{
    internal class ProdutoControlador
    {
        private ProdutoServico produtoServico = new ProdutoServico();
        public void GerenciarMenu()
        {
            int codigo = 0;
            //Repete enquanto o codigo não for o menu sair(6)
            while (codigo != 6)
            {
                Console.Clear();
                //Apresenta o menu e solicita o codigo
                codigo = ApresentarSolicitarMenu();
                Console.Clear();

                if (codigo == 1)
                {
                    //menu escolhido para listar produtos
                    ApresentarProdutos();
                }
                else if (codigo == 2)
                {
                    //menu escolhido para cadastrar produto
                    Cadastrar();
                }
                else if (codigo == 3)
                {
                    //menu escolhido para editar produto
                    Editar();
                }
                else if (codigo == 4)
                {
                    Apagar();
                }
                else if (codigo == 5)
                {
                    ApresentarProduto();
                }
                Console.WriteLine("\n\nAperte alguma tecla para continuar...");
                Console.ReadKey();
            }
        }

        private void ApresentarProduto()
        {
            ApresentarProdutos();

            Console.WriteLine("Digite o codigo do produto a ser detalhado: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            var produto = produtoServico.ObterPorCodigo(codigo);

            //Verifica se o produto não esta cadastrado na lista de produtos
            if (produto == null)
            {
                Console.WriteLine("Produto não cadastrado");

                return;
            }

            Console.Clear();
            Console.WriteLine(@$"Código: {produto.Codigo} 
Nome: {produto.Nome}
Preço unitário: {produto.PrecoUnitario}
Quantidade: {produto.Quantidade}
Total: {produto.CalcularPrecoTotal()}");

        }
        private void Apagar()
        {
            ApresentarProdutos();

            Console.WriteLine("Digite o codigo do produto para apagar: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            var registroApagado = produtoServico.Apagar(codigo);

            Console.WriteLine(registroApagado == true
                ? "Registro removido com sucesso"
                : "Nenhum produto cadastrado com codigo informado");
        }
        private void Editar()
        {
            ApresentarProdutos();

            Console.WriteLine("Codigo produo desejado: ");
            var codigo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nome: ");
            var nome = Console.ReadLine();

            Console.Write("Quantidade: ");
            var quantidade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Preço unitário: ");
            var precoUnitario = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(@"Localizações disponiveis: 
- Armazem
- Area Venda
- Loja");
            Console.WriteLine("Localização: ");
            var localizacao = Console.ReadLine();

            var localizacaoProduto = ObterLocalizacaoProduto(localizacao);

            var alterou = produtoServico.Editar(codigo, nome, precoUnitario, localizacaoProduto, quantidade);

            if (alterou == false)
            {
                Console.WriteLine("Codigo digitado não existe");
            }
            else
            {
                Console.WriteLine("Produto alterado com sucesso");
            }
        }
        public int ApresentarSolicitarMenu()
        {
            Console.WriteLine(@"  MENU
1- LISTAR TODOS
2- CADASTRAR
3- EDITAR
4- APAGAR
5- APRESENTAR PRODUTO DESEJADO
6- SAIR");

            int codigo = SolicitarCodigo();
            return codigo;
        }
        private int SolicitarCodigo()
        {
            int codigo = 0;
            //Continua solicitando o codigo até que seja um codigo entre 1 e 6
            while (codigo < 1 || codigo > 6)
            {
                try
                {
                    Console.Write("Digite o codigo: ");
                    codigo = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Digite um menu valido");
                }
            }
            return codigo;
        }
        private void Cadastrar()
        {
            Console.WriteLine("Nome: ");
            var nome = Console.ReadLine();

            Console.WriteLine("Quantidade: ");
            var quantidade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Preço Unitário: ");
            var precoUnitario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(@"Localizações disponiveis:
- Armazem
- Area Venda
- Loja");
            Console.WriteLine("Localização: ");
            var localizacao = Console.ReadLine();

            var localizacaoProduto = ObterLocalizacaoProduto(localizacao);

            produtoServico.Adicionar(nome, precoUnitario, localizacaoProduto, quantidade);

        }
        private ProdutoLocalizacao ObterLocalizacaoProduto(string localizacao)
        {
            if (localizacao.ToLower() == "armazem")
            {
                return ProdutoLocalizacao.Armazem;
            }
            else if (localizacao.ToLower() == "loja")
            {
                return ProdutoLocalizacao.Loja;
            }
            else
            {
                return ProdutoLocalizacao.AreaVenda;
            }
        }
        private void ApresentarProdutos()
        {
            var produtos = produtoServico.ObterTodos();

            if (produtos.Count == 0)
            {
                Console.WriteLine("Nenhum produto cadastrado :(");
                //Para a execução deste método
                return;
            }

            Console.WriteLine("Listas de Produtos");

            for (var i = 0; i < produtos.Count; i++)
            {
                var produtoAtual = produtos[i];

                Console.WriteLine("\nCódigo: " + produtoAtual.Codigo + "\nNome: " + produtoAtual.Nome + "\n");
            }
        }
    }
}
