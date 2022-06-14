namespace Entra21.ExerciciosListas.Exercicio01Triangulo
{
    internal class TrianguloServico
    {
        private List<Triangulo> triangulos = new List<Triangulo>();

        private int codigoAtual = 1;
        public bool AdicionarTriangulo(int Lado1, int Lado2, int Lado3)
        {
            Triangulo triangulo = new Triangulo();

            triangulo.Lado1 = Lado1;
            triangulo.Lado2 = Lado2;
            triangulo.Lado3 = Lado3;
            triangulo.Codigo = codigoAtual;

            if (triangulo.ValidarTriangulo() == true)
            {
                codigoAtual += +1;

                triangulos.Add(triangulo);

                return true;
            }

            return false;
        }
        public bool EditarTriangulo(int codigoEditar, int lado1, int lado2, int lado3)
        {
            Triangulo trianguloEditar = ObterPorCodigo(codigoEditar);

            if (trianguloEditar == null)
            {
                return false;
            }

            trianguloEditar.Lado1 = lado1;
            trianguloEditar.Lado2 = lado2;
            trianguloEditar.Lado3 = lado3;

            if (trianguloEditar.ValidarTriangulo() == true)
            {
                triangulos.Add(trianguloEditar);

                return true;
            }

            return false;
        }
        public bool ApagarTriangulo(int codigo)
        {
            Triangulo trianguloApagar = ObterPorCodigo(codigo);

            if (trianguloApagar == null)
            {
                return false;
            }

            triangulos.Remove(trianguloApagar);

            return true;
        }
        public List<Triangulo> ObterTodos()
        {
            return triangulos;
        }
        public Triangulo ObterPorCodigo(int codigo)
        {
            for (int i = 0; i < triangulos.Count; i++)
            {
                var trianguloAtual = triangulos[i];

                if (trianguloAtual.Codigo == codigo)
                {
                    return trianguloAtual;
                }
            }
            return null;
        }
    }
}
