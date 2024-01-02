//Escreva um programa que apresente na 
//tela o menor numero de um vetor
// v = { 5, 7, 23, 5, 2} = 2

int[] vetor = new int[] { 5, 2, 7, 23, 5, 1 };

int iMenor = 0;

for (int i = 0; i < vetor.Length; i++)
{
    if (vetor[i] < vetor[iMenor])
    {
        iMenor = i;
    }
}

Console.WriteLine(vetor[iMenor]);
