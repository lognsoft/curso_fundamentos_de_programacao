// 2 - Escreva um programa que mostro todos os numeros 
// anteriores do numero que o usuario digitou.

Console.WriteLine("Digite um numero");
int numero = Convert.ToInt32(Console.ReadLine());

int total = 0;

for (int i = numero - 1; i > 0; i--)
{
    total += i;
    Console.WriteLine($"Numeros anteriores {i}");
}

Console.WriteLine("Total de todos os numeros somados " + total);