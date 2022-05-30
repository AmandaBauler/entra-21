using Entra21.ExerciciosOrientacaoObjetos.Exercicio01;
using Entra21.ExerciciosOrientacaoObjetos.Exercicio02;
using Entra21.ExerciciosOrientacaoObjetos.Exercicio03;

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
else if(opcaoDesejada == 2)
{
    ExemploTemperatura exemploTemperatura = new ExemploTemperatura();
    exemploTemperatura.Executar();
}
else if(opcaoDesejada == 3)
{
    ExemploConversorAscii exemploConversorAscii = new ExemploConversorAscii();
    exemploConversorAscii.Executar();
}