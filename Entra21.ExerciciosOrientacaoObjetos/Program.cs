using Entra21.ExerciciosOrientacaoObjetos.Exercicio01;

Console.WriteLine(@"------------Menu-----------
1- Atividade 01
5- Atividade 02
8- Atividade 03
10- Atividade 05");

Console.WriteLine("Escolha uma opção do menu: ");
int opcaoDesejada = Convert.ToInt32(Console.ReadLine());

if(opcaoDesejada == 1)
{
    ExemploLivro exemploLivro = new ExemploLivro();
    exemploLivro.Executar();
}
