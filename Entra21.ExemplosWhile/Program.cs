// See https://aka.ms/new-console-template for more information
using Entra21.ExemplosWhile;

Console.WriteLine(@"----------------Menu--------------
1- Exemplo 01
2- Exemplo 02
3- Exemplo 03");

Console.WriteLine("Digite a opção desejada: ");
int opcaoDesejada = Convert.ToInt32(Console.ReadLine());

if (opcaoDesejada == 1)
{
    Exemplo01 meuExemplo01 = new Exemplo01();
    meuExemplo01.Executar();

}
else if (opcaoDesejada == 2)
{
    Exemplo02 nossoExemplo = new Exemplo02();
    nossoExemplo.Executar();
}
else if (opcaoDesejada == 3)
{
    Exemplo03 delesExemplo = new Exemplo03();
    delesExemplo.Executar();
}