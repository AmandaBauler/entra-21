﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entra21.ExerciciosOrientacaoObjetos.Exercicio02;
using FluentAssertions;
using Xunit;

namespace Entra21.ExerciciosOrientacaoObjetos.Testes.Exercicio02
{
    public class TemperaturaTestes
    {
        [Fact]
        public void Validar_CalcularCelsiusParaFahrenheit()
        {
            //Arrange
            Temperatura temperatura = new Temperatura();
            temperatura.TemperaturaAtual = 42.7;

            //Act
            var temperaturaConvertida = temperatura.CalcularCelsiusParaFahrenheit();

            //Assert
            temperaturaConvertida.Should().Be(42.7 * 1.8 + 32);

        }

        [Fact]
        public void Validar_CalcularCelsiusParaKelvin()
        {
            //Arrange
            Temperatura temperatura = new Temperatura();
            temperatura.TemperaturaAtual = 42;

            //Act
            var temperaturaConvertida = temperatura.CalcularCelsiusParaKelvin();

            //Assert
            temperaturaConvertida.Should().Be(42 + 273);
        }

        [Fact]
        public void Validar_CalcularKelvinParaCelsius()
        {
            //Arrange
            Temperatura temperatura = new Temperatura();
            temperatura.TemperaturaAtual = 42.7;

            //Act
            var temperaturaConvertida = temperatura.CalcularKelvinParaCelsius();

            //Assert
            temperaturaConvertida.Should().Be(42 - 273);
        }



    }
}
