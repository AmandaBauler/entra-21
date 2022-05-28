using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjetos.Exercicio02
{
    public class ExemploTemperatura
    {
        public void Executar()
        {
            var temperatura = new Temperatura();
            temperatura.TipoTemperaturaOrigem = "C";
            temperatura.TipoTemperaturaDestino = "F";
            temperatura.TemperaturaAtual = 42.30;

           //Console.WriteLine("Temperatura convertida: " + temperatura.ApresentarTemperatura());
        }
    }
}
