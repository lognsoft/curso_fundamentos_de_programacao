// 3 - Escreva um programa que leia o preco de um determinado 
// produto e calcule seu valor de venda acrescentando 25% do valor.

System.Console.WriteLine("Digite o nome do produto");
string nomeProduto = Console.ReadLine();

System.Console.WriteLine("Digite o valor do produto");
double valorProduto = Convert.ToDouble(Console.ReadLine());

double total = valorProduto += valorProduto * 0.25;

System.Console.WriteLine($"Produto:{nomeProduto} Valor: {valorProduto}");



