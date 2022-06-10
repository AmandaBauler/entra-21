namespace Entra21.ExerciciosListas.Exercicio01Triangulo
{
    internal class Triangulo
    {
        public int Codigo;
        public int Lado1;
        public int Lado2;
        public int Lado3;

        public bool ValidarTriangulo()
        {
            var somaLadosTriangulo = (Lado1 + Lado2) < Lado3;
            //Math.Abs(calculo aqui)
            //Criar outras variáveis para o triangulo.
            //&&

            if (somaLadosTriangulo == true)
            {
                return true;
            }
            return false;
        }
    }
}
