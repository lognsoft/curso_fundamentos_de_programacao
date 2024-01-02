// Faça um programa, utilizando for, que permita o usuário fazer três contas de soma entre 2 numeros.

for (int i = 0; i < 3; i++)
{

    Console.WriteLine("-------------------Conta: {0}------------------", i + 1);

    Console.WriteLine("digite o numero 1");
    int numero1 = Convert.ToInt16(Console.ReadLine());

    Console.WriteLine("digite o numero 2");
    int numero2 = Convert.ToInt16(Console.ReadLine());

    Console.WriteLine("Total da soma {0}", numero1 + numero2);
}

Console.WriteLine("Todas as 3 contas ja foram efetuadas");
