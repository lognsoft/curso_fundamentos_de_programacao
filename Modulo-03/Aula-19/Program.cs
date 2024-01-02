// 4 - Escreva um programa que calcule a media de um aluno,
// a quantidade de notas nao deverao ser limitadas, o usuario do programa devera
// escolher a quantidade de notas a serem calculadas.
// Exibir o calculo da media.

double media = 0;
double totalNotas = 0;

System.Console.WriteLine("Digite a quantidade de notas a serem calculadas");
int qntNotas = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < qntNotas; i++)
{
    Console.WriteLine($"Digite a nota {i + 1}");
    totalNotas += Convert.ToDouble(Console.ReadLine());
}
media = totalNotas / qntNotas;

System.Console.WriteLine($"Total da media: {media}");


