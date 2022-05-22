using Entra21.ExerciciosVetor;

Console.WriteLine(@"------------Menu-----------
1- Atividade 01
2- Atividade 02
3- Atividade 03
4- Atividade 04
5- Atividade 05
6- Atividade 06
7- Atividade 07
8- Atividade 08
9- Atividade 09
10- Atividade 10
11- Atividade 11
12- Atividade 12
13- Atividade 13
14- Atividade 14");

Console.WriteLine("Digite uma opção: ");
int opcaoDesejada = Convert.ToInt32(Console.ReadLine());

if (opcaoDesejada == 1)
{
    Exercicio01 exercicio01 = new Exercicio01();
    exercicio01.Executar();
}
else if (opcaoDesejada == 2)
{
    Exercicio02 exercicio02 = new Exercicio02();
    exercicio02.Executar();
}
else if (opcaoDesejada == 3)
{
    Exercicio03 exercicio03 = new Exercicio03();
    exercicio03.Executar();
}
else if (opcaoDesejada == 4)
{
    Exercicio04 exercicio04 = new Exercicio04();
    exercicio04.Executar();
}
else if (opcaoDesejada == 5) 
{
    Exercicio05 exercicio05 = new Exercicio05();
    exercicio05.Executar();
}
else if (opcaoDesejada == 6)
{
    Exercicio06 exercicio06 = new Exercicio06();
    exercicio06.Executar();
}
else if (opcaoDesejada == 7)
{
    Exercicio07 exercicio07 = new Exercicio07();
    exercicio07.Executar();
}
else if (opcaoDesejada == 8)
{
    Exercicio08 exercicio08 = new Exercicio08();
    exercicio08.Executar();
}
else if (opcaoDesejada == 9)
{
    Exercicio09 exercicio09 = new Exercicio09();
    exercicio09.Executar();
}

