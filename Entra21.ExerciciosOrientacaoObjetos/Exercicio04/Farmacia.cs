using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjetos.Exercicio04
{
    public class Farmacia
    {
        public string RazaoSocial;
        public string Cnpj;
        public string[] NomesProdutos = new string[3];
        public double[] PrecosProdutos = new double[3];
        public string[] CategoriaProdutos = new string[3];

        public double CalcularPrecoTotalProdutos()
        {
            double totalProdutos = 0;
            for (int i = 0; i < PrecosProdutos.Length; i++)
            {
                totalProdutos = totalProdutos + PrecosProdutos[i];
            }

            return totalProdutos;
        }
        public void ApresentarPrecoTotalPedidos()
        {
            CalcularPrecoTotalProdutos();
        }
        public bool VerificarCategoriaProdutosEhAntibiotico()
        {
            for (int i = 0; i < NomesProdutos.Length; i++)
            {
                if (CategoriaProdutos[i] == "Antibiotico")
                {
                    return true;
                }
            }

            return false;
        }
        public double CalcularValoresPorCategoriaAntibiotico()
        {
            var totalPedidosAntibiotico = 0.0;

            if (VerificarCategoriaProdutosEhAntibiotico() == true)
            {
                for (int i = 0; i < NomesProdutos.Length; i++)
                {
                    totalPedidosAntibiotico = totalPedidosAntibiotico + PrecosProdutos[i];
                }
            }

            return totalPedidosAntibiotico;
        }
        public void ApresentarValorProdutoAntibiotico()
        {
            CalcularValoresPorCategoriaAntibiotico();
        }
        public int CalcularQuantidadePedidosAntibioticos()
        {
            int quantidadeAntibioticos = 0;
            if (VerificarCategoriaProdutosEhAntibiotico() == true)
            {
                for (var i = 0; i < NomesProdutos.Length; i++)
                {
                    if (CategoriaProdutos[i] == "Antibiotico")
                    {
                        quantidadeAntibioticos += 1;
                    }
                }
            }

            return quantidadeAntibioticos;

        }
        public bool VerificarCategoriaProdutosEhAntiinflamatorio()
        {
            for (int i = 0; i < NomesProdutos.Length; i++)
            {
                if (CategoriaProdutos[i] == "Antibiotiinflamatorio")
                {
                    return true;
                }
            }
            return false;
        }
        public double CalcularValoresPorCategoriaAntiinflamatorio()
        {
            var totalPedidosAntiinflamatorio = 0.0;

            if (VerificarCategoriaProdutosEhAntiinflamatorio() == true)
            {
                for (int i = 0; i < NomesProdutos.Length; i++)
                {
                    totalPedidosAntiinflamatorio = totalPedidosAntiinflamatorio + PrecosProdutos[i];
                }
            }

            return totalPedidosAntiinflamatorio;
        }
        public void ApresentarValorProdutoAntiinflamatorio()
        {
            CalcularValoresPorCategoriaAntiinflamatorio();
        }
    }
}
