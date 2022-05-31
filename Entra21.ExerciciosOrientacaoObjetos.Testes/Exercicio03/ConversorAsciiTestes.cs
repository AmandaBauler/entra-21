using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entra21.ExerciciosOrientacaoObjetos.Exercicio03;
using FluentAssertions;
using Xunit;

namespace Entra21.ExerciciosOrientacaoObjetos.Testes.Exercicio03
{
    public class ConversorAsciiTestes
    {
        [Theory]
        [InlineData("A", 65)]
        [InlineData("B", 66)]
        [InlineData("C", 67)]
        [InlineData("D", 68)]
        [InlineData("E", 69)]
        [InlineData("F", 70)]
        [InlineData("G", 71)]
        [InlineData("H", 72)]
        [InlineData("I", 73)]
        [InlineData("J", 74)]
        [InlineData("K", 75)]
        [InlineData("L", 76)]
        [InlineData("M", 77)]
        [InlineData("N", 78)]
        [InlineData("O", 79)]
        [InlineData("P", 80)]
        [InlineData("Q", 81)]
        [InlineData("R", 82)]
        [InlineData("S", 83)]
        [InlineData("T", 84)]
        [InlineData("U", 85)]
        [InlineData("V", 86)]
        [InlineData("W", 87)]
        [InlineData("X", 88)]
        [InlineData("Y", 89)]
        [InlineData("Z", 90)]
        [InlineData("a", 97)]
        [InlineData("b", 98)]
        [InlineData("c", 99)]
        [InlineData("d", 100)]
        [InlineData("e", 101)]
        [InlineData("f", 102)]
        [InlineData("g", 103)]
        [InlineData("h", 104)]
        [InlineData("i", 105)]
        [InlineData("j", 106)]
        [InlineData("k", 107)]
        [InlineData("l", 108)]
        [InlineData("m", 109)]
        [InlineData("n", 110)]
        [InlineData("o", 111)]
        [InlineData("p", 112)]
        [InlineData("q", 113)]
        [InlineData("r", 114)]
        [InlineData("s", 115)]
        [InlineData("t", 116)]
        [InlineData("u", 117)]
        [InlineData("v", 118)]
        [InlineData("w", 119)]
        [InlineData("x", 120)]
        [InlineData("y", 121)]
        [InlineData("z", 122)]
        [InlineData("0", 48)]
        [InlineData("1", 49)]
        [InlineData("2", 50)]
        [InlineData("3", 51)]
        [InlineData("4", 52)]
        [InlineData("5", 53)]
        [InlineData("6", 54)]
        [InlineData("7", 55)]
        [InlineData("8", 56)]
        [InlineData("9", 57)]
        [InlineData(":", 58)]
        [InlineData(";", 59)]
        [InlineData("<", 60)]
        [InlineData("=", 61)]
        [InlineData(">", 62)]
        [InlineData("?", 63)]
        [InlineData("@", 64)]
        [InlineData("'", 96)]
    
        public void Validar_CodigoAscii(string caracter, int numeroEsperado)
        {
            //Arrenge
            var codigoAscii = new ConversorAscii();
            codigoAscii.Caracteres = caracter;

            //Act
            var caracterConvertido = codigoAscii.ConferirCodigoAscii();

            //Assert
            caracterConvertido.Should().Be(numeroEsperado);
        }
    }
}
