// Faça um programa, utilizando for, que peça ao usuário um número que ele deseja efetuar a tabuada, 
// o segundo numero que o usuario digitar, sera a quantidade de vezes que a tabuada sera calculada.

Console.WriteLine("Digite o numero da tabuada");
int numeroTabuada = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Digite a quantidade de vezes que voce deseja que a tabuada seja calculada");
int quantidadeVezesCalculo = Convert.ToInt16(Console.ReadLine());

for (int i = 0; i < quantidadeVezesCalculo; i++)
{
    int resultado = numeroTabuada;
    Console.WriteLine("{0} x {1} = {2}", numeroTabuada, i);
}
