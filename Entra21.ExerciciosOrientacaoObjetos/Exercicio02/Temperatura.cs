using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjetos.Exercicio02
{
    public class Temperatura
    {
        public string TipoTemperaturaOrigem;
        public string TipoTemperaturaDestino;
        public double TemperaturaAtual;

        public double CalcularCelsiusParaFahrenheit()
        {
            return (TemperaturaAtual * 1.8) + 32;
        }
        public double CalcularCelsiusParaKelvin()
        {
            return TemperaturaAtual + 273;
        }
        public double CalculandoCelsius()
        {
            return TemperaturaAtual;
        }
        public double CalcularKelvinParaCelsius()
        {
            return TemperaturaAtual - 273;
        }
        public double CalculandoKelvinParaFahrenheit()
        {
            return ((TemperaturaAtual - 273) * 1.8) + 32;

        }
        public double CalcularKelvin()
        {
            return TemperaturaAtual;
        }
        public double CalcularFahrenheitParaCelsius()
        {
            return (TemperaturaAtual - 32) / 1.8;
        }
        public double CalcularFahrenheitParaKelvin()
        {
            return ((TemperaturaAtual - 32) * 5 / 9) + 273;
        }
        public double CalcularFahrenheit()
        {
            return TemperaturaAtual;
        }
        public double ApresentarTemperatura()
        {
            if (TipoTemperaturaOrigem.StartsWith("C") && TipoTemperaturaDestino.StartsWith("F"))
            {
                return CalcularCelsiusParaFahrenheit();
            }
            else if (TipoTemperaturaOrigem.StartsWith("C") && TipoTemperaturaDestino.StartsWith("K"))
            {
                return CalcularCelsiusParaKelvin();
            }
            else if (TipoTemperaturaOrigem.StartsWith("C") && TipoTemperaturaDestino.StartsWith("C"))
            {
                return CalculandoCelsius();
            }
            else if (TipoTemperaturaOrigem.StartsWith("K") && TipoTemperaturaDestino.StartsWith("C"))
            {
                return CalcularKelvinParaCelsius();
            }
            else if (TipoTemperaturaOrigem.StartsWith("K") && TipoTemperaturaDestino.StartsWith("F"))
            {
                return CalculandoKelvinParaFahrenheit();
            }
            else if (TipoTemperaturaOrigem.StartsWith("K") && TipoTemperaturaDestino.StartsWith("K"))
            {
                return CalcularKelvin();
            }
            else if (TipoTemperaturaOrigem.StartsWith("F") && TipoTemperaturaDestino.StartsWith("C"))
            {
                return CalcularFahrenheitParaCelsius();
            }
            else if (TipoTemperaturaOrigem.StartsWith("F") && TipoTemperaturaDestino.StartsWith("K"))
            {
                return CalcularFahrenheitParaKelvin();
            }
            else if (TipoTemperaturaOrigem.StartsWith("F") && TipoTemperaturaDestino.StartsWith("F"))
            {
                return CalcularFahrenheit();
            }

            return TemperaturaAtual;
        }



    }
}
