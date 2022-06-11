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
            int subtracaoLado23 = Math.Abs(Lado2 - Lado3);
            int subtracaoLado13 = Math.Abs(Lado1 - Lado3);
            int subtracaoLado12 = Math.Abs(Lado1 - Lado2);
            int somaLado13 = (Lado1 + Lado3);
            int somaLado23 = (Lado2 + Lado3);
            int somaLado12 = (Lado1 + Lado2);

            //cirar novos metodos, os if não estão corretos: Exemplo 
            //private bool IsLado1Valido() e fazer o primeiro if la dentro.
            if (subtracaoLado23 < Lado1 && somaLado23 < Lado1)
            {
                if (subtracaoLado13 < Lado2 && somaLado13 < Lado2)
                {
                    if (subtracaoLado12 < Lado3 && somaLado12 < Lado3)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
