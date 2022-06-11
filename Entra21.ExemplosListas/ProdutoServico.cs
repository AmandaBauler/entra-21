namespace Entra21.ExemplosListas
{
    internal class ProdutoServico
    {
        private List<Produto> produtos = new List<Produto>();

        //Armazenar o codigo do proximo produto
        private int codigoAtual = 1;
        //encapsulamento + tipoRetorno + NomeMetodo(parametros)
        public void Adicionar(string nome, double precoUnitario, ProdutoLocalizacao localizacao, int quantidade)
        {
            //Instanciar um objeto da classe Produto
            Produto produto = new Produto();

            //Atribuir valor para as propriedades com os dados passados como parametro
            produto.Nome = nome;
            produto.PrecoUnitario = precoUnitario;
            produto.Localizacao = localizacao;
            produto.Quantidade = quantidade;

            //Atribuindo o codigo novo para o objeto do produto
            produto.Codigo = codigoAtual;

            //Adicionar 1 no codigo atual para quando criar um novo produto o produto conter outro código
            codigoAtual = codigoAtual + 1;

            //Adicionar o produto instanciado na lista de produtos
            produtos.Add(produto);
        }
        public bool Editar(int codigoParaAlterar, string nome, int precoUnitario, ProdutoLocalizacao localizacao, int quantidade)
        {
            //Obtem o produto desejado da lista de produtos
            Produto produtoParaAlterar = ObterPorCodigo(codigoParaAlterar);

            //Verifica senão foi possivel encontrar o produto
            if (produtoParaAlterar == null)
            {
                // Retorna falso pq não existe produto com o codigo dos parametros
                return false;
            }

            //Atualiza as propriedades (campos) do produto desejado
            produtoParaAlterar.Nome = nome;
            produtoParaAlterar.Localizacao = localizacao;
            produtoParaAlterar.PrecoUnitario = precoUnitario;
            produtoParaAlterar.Quantidade = quantidade;

            //Retorna verdadeiro pq foi possivel alterar o produto
            return true;
        }
        public bool Apagar(int codigo)
        {
            for (int i = 0; i < produtos.Count; i++)
            {
                //Resgatando de uma lista de tipos primitivos
                //int numero = numeros[i]

                //Resgatando de uma lista de objetos
                Produto produto = produtos[i];
                if (produto.Codigo == codigo)
                {
                    //Posso remover com o indice do objeto desejado
                    //produtos.RemoveAt(i);

                    //As duas formas estão corretas.

                    //Posso remover com objeto desejado
                    produtos.Remove(produto);

                    //Retorna verdadeiro pq o produto com o codigo desejado foi removido
                    return true;
                }

            }
            //Retorna falso pq não foi encontrado produto com o codigo desejado foi removido da lista
            return false;

        }
        public List<Produto> ObterTodos()
        {
            return produtos;
        }
        public Produto ObterPorCodigo(int codigo)
        {
            //Percorrer todos os elementos par encontrar o produto
            //filtrando por codigo.
            for (int i = 0; i < produtos.Count; i++)
            {
                //Obter o produto de lista de produtos em determinado indice
                var produtoAtual = produtos[i];

                //verifica se o produto atual da lista percorrida é desejado
                if (produtoAtual.Codigo == codigo)
                {
                    //Retorna o produto encontrado
                    return produtoAtual;
                }
            }
            //Retorna null, caso não encontre um produto com codigo passado com parametro
            return null;
        }
        public Produto ObterMenorPrecoUnitario()
        {
            double menorPrecoUnitario = double.MaxValue;
            Produto produtoMenorPrecoUnitario = null;

            //Percorre a lista de produtos para obter o produto com o menor preço unitario.
            for (int i = 0; i < produtos.Count; i++)
            {
                //Obter o produto atual da lista que esta sendo percorrida.
                Produto produto = produtos[i];
                
                //Verifica se o produto atual possui o menor preço unitario.
                if (produto.PrecoUnitario < menorPrecoUnitario)
                {
                    //Armazena o preço unitario, pois é o menor preço unitario até o momento.
                    menorPrecoUnitario = produto.PrecoUnitario;
                    //Armazena o produto para posteriormente saber qual é o produto com menor preço unitario.
                    produtoMenorPrecoUnitario = produto;
                }
            }

            return produtoMenorPrecoUnitario;
        }
        public List<double> ObterTodosPrecos()
        {
            //Criar uma lista de preços totais
            var precos = new List<double>();

            //Percorre todos os produtos
            for(int i = 0; i < produtos.Count; i++)
            {
                //Obtém o produto atual da lista de produtos
                var produto = produtos[i];

                //Adiciona o preço total na lista de preços
                precos.Add(produto.CalcularPrecoTotal());
            }

            return precos;
        }
        public List<double> ObterPrecosTotaisFiltrandoPorLocalizacao(ProdutoLocalizacao localizacao)
        {
            //Criar uma lista de preços totais
            var precos = new List<double>();

            //Percorrer todos os produtos
            for (int i = 0; i < produtos.Count; i++)
            {
                //Obtém o produto atual da lista de produtos
                var produto = produtos[i];

                //Verifica se a localização do produto atual é a localização passada no paramentro
                if (produto.Localizacao == localizacao)
                {
                    //Adiciona o preço total do produto atual que foi filtrado por localização
                    precos.Add(produto.CalcularPrecoTotal());
                }
            }

            return precos;
        }
        public List<double> ObterPrecosTotaisDoArmazem()
        {
            //Criar uma lista de preços totais
            var precos = new List<double>();

            //Percorrer todos os produtos
            for (int i = 0; i < produtos.Count; i++)
            {
                //Obtem o produto atual da lista de produtos
                var produto = produtos[i];

                //Verifica se a localização do produto atual é armazém
                if (produto.Localizacao == ProdutoLocalizacao.Armazem)
                {
                    //Adiciona o preço total do produto atual que foi filtrado por armazém
                    precos.Add(produto.CalcularPrecoTotal());
                }
            }

            return precos;
        }
        public double ObterMediaPrecoTotatis()
        {
            var somaPrecosTotais = 0.0;

            //Percorre todos os produtos
            for (int i = 0; i < produtos.Count; i++)
            {
                //Obtem o produto atual da lista de produtos
                var produto = produtos[i];

                //Adiciona o preço total do produto na variavel soma de preços totais
                somaPrecosTotais += produto.CalcularPrecoTotal();
            }

            //Calcula a media de acordo com a quantidade de produtos.
            var media = somaPrecosTotais / produtos.Count;

            return media;
        }
    }
}
