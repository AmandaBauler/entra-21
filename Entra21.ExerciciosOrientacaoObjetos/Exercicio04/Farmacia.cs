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
        public double CalcularValoresPorCategoriaAntibiotico()
        {
            var totalPedidosAntibiotico = 0.0;

            for(int i = 0; i < NomesProdutos.Length; i++)
            {
                if(CategoriaProdutos[i] == "Antibiotico")
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

            for (int i = 0; i < NomesProdutos.Length; i++)
            {
                if(CategoriaProdutos[i] == "Antibiotico")
                {
                    quantidadeAntibioticos++;
                }

            }
            
            return quantidadeAntibioticos;

        }
        public void ApresentarQuantidadeAntibiotco()
        {
            CalcularQuantidadePedidosAntibioticos();
        }
     
        public double CalcularValoresPorCategoriaAntiinflamatorio()
        {
            var totalPedidosAntiinflamatorio = 0.0;
           for(int i = 0; i < NomesProdutos.Length; i++)
            {
                if (CategoriaProdutos[i] == "Antiinflamatorio")
                {
                    totalPedidosAntiinflamatorio++;
                }
            }

            return totalPedidosAntiinflamatorio;
        }
        public void ApresentarValorProdutoAntiinflamatorio()
        {
            CalcularValoresPorCategoriaAntiinflamatorio();
        }
        public int CalularQuantidadePedidosAntiinflamatorio()
        {
            int quantidadeAntiinflamatorio = 0;
           for( int i = 0; i < NomesProdutos.Length; i++)
            {
                if(CategoriaProdutos[i] == "Antiinflamatorio")
                {
                    quantidadeAntiinflamatorio++;
                }
            }

            return quantidadeAntiinflamatorio;
        }
        public void ApresentarQuantidadeAntiinflamatorio()
        {
            CalularQuantidadePedidosAntiinflamatorio();
        }
    }
}
