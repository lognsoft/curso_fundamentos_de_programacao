double Soma = 0;

System.Console.WriteLine("Digite a quantidade de numeros a ser somado");
double quantidadeDeNumeros = Convert.ToDouble(Console.ReadLine());

for (var i = 0; i < quantidadeDeNumeros; i++)
{
    Console.WriteLine("Digite o numero {0}", i + 1);
    Soma += Convert.ToDouble(Console.ReadLine());
}

System.Console.WriteLine("Total: {0}", Soma);