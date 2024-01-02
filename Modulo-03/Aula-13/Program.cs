// 1 - Escreva um programa que some 2 numeros digitados pelo 
// usuario e depois divida por 2, mostre o resultado da soma 
// entre os 2 numeros, e o resultado da divisao.

Console.WriteLine("Digite o primeiro numero");
double numero1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o segundo numero");
double numero2 = Convert.ToDouble(Console.ReadLine());

double totalSoma = numero1 + numero2;

Console.WriteLine($"Total: {numero1} + {numero2} = {totalSoma}");

Console.WriteLine($"Total: {totalSoma} / 2 = {totalSoma / 2}");




