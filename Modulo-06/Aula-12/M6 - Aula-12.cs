//Crie um programa que some todos os numeros de um vetor
//Ex: v = {5,5,5,5,10} resultado: 30
//E exiba o resultado na tela.

int[] vetor = new int[] { 5, 5, 5, 5, 10 };

int total = 0;

foreach (int item in vetor)
{
    total += item;
}

Console.WriteLine(total);