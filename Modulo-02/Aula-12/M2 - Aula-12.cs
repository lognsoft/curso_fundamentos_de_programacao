// 1 - Escreva um programa para ler 2 valores 
// (considere que não serão informados valores iguais) e escrever o maior deles.

Console.WriteLine("Digite o valor 1");
int valor1 = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Digite o valor 2");
int valor2 = Convert.ToInt16(Console.ReadLine());

if (valor1 > valor2)
{
    Console.WriteLine("Valor 1 e maior que valor 2");
}
else
{
    Console.WriteLine("Valor 2 e maior que valor 1");
}







