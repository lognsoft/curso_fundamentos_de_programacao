//MEDIA DAS NOTAS
//Escreva um programa que calcule todas notas de 
//Um vetor e exiba a media.
//Ex: v = {4, 8, 6, 3, 8, 2, 10}

int[] v = new int[] { 4, 8, 6, 3, 8, 2, 10 };

int total = 0;

foreach (var item in v)
{
    total += item;
}

Console.WriteLine($"Media: {total / v.Length}");