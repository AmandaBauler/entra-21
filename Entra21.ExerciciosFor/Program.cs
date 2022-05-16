//See https://aka.ms/new-console-template for more information
using Entra21.ExerciciosFor;

Console.WriteLine(@"------------Menu-----------
1- Atividade 01
5- Atividade 05
8- Atividade 08
10- Atividade 10
12- Atividade 12
13- Atividade 13");

Console.WriteLine("Digite uma opção: ");
int opcaoDesejada = Convert.ToInt32(Console.ReadLine());

if (opcaoDesejada == 1)
{
    Exercicio01 exercicio01 = new Exercicio01();
    exercicio01.Executar();
}
else if (opcaoDesejada == 5)
{
    Exercicio05 exercicio05 = new Exercicio05();
    exercicio05.Executar();
}
else if (opcaoDesejada == 8)
{
    Exercicio08 exercicio08 = new Exercicio08();
    exercicio08.Executar();
}
else if (opcaoDesejada == 10)
{
    Exercicio10 exercicio10 = new Exercicio10();
    exercicio10.Executar();
}
else if (opcaoDesejada == 12)
{
    Exercicio12 exercicio12 = new Exercicio12();
    exercicio12.Executar();
}
else if (opcaoDesejada == 13)
{
    Exercicio13 exercicio13 = new Exercicio13();
    exercicio13.Executar();
}