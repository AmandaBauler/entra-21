using Entra21.ExerciciosListas.Exercicio02;

Console.WriteLine(@"----------------Menu--------------
1- Opção 01
2- Opção 02
3- Opção 03");

Console.WriteLine("Escolha uma das opções: ");
int opcaoDesejada = Convert.ToInt32(Console.ReadLine());

if(opcaoDesejada == 1)
{
    Exercicio01 exercicio01 = new Exercicio01();
    exercicio01.Executar();
}
else if(opcaoDesejada == 2)
{
    Exercicio02 exercicio02 = new Exercicio02();
    exercicio02.Executar();
}
else if(opcaoDesejada == 3)
{
    Exercicio03 exercicio03 = new Exercicio03();
    exercicio03.Executar();
}
