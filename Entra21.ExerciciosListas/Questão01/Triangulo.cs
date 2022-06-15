namespace Entra21.ExerciciosListas.Exercicio01Triangulo
{
    internal class Triangulo
    {
        public int Codigo;
        public int Lado1;
        public int Lado2;
        public int Lado3;


        //cirar novos metodos, os if não estão corretos: Exemplo 
        //private bool IsLado1Valido() e fazer o primeiro if la dentro.
        public bool ValidarTriangulo()
        {
            if (IsLado1Valido() == true && IsLado2Valido() == true && IsLado3Valido() == true)
            {
                return true;
            }

            return false;
        }
        private bool IsLado1Valido()
        {
            int subtracaoLado23 = Math.Abs(Lado2 - Lado3);
            int somaLado23 = (Lado2 + Lado3);

            if (subtracaoLado23 < Lado1 && Lado1 < somaLado23)
            {
                return true;
            }

            return false;
        }
        private bool IsLado2Valido()
        {
            int subtracaoLado13 = Math.Abs(Lado1 - Lado3);
            int somaLado13 = (Lado1 + Lado3);

            if (subtracaoLado13 < Lado2 && Lado2 < somaLado13)
            {
                return true;
            }

            return false;
        }
        private bool IsLado3Valido()
        {
            int subtracaoLado12 = Math.Abs(Lado1 - Lado2);
            int somaLado12 = (Lado1 + Lado2);

            if (subtracaoLado12 < Lado3 && Lado3 < somaLado12)
            {
                return true;
            }

            return false;
        }
        




    }
}
