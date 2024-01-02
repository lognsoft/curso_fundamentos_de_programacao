int[] numeros = new int[] { 7, 40, 323, 3, 4, 2, 6, 4, 3, 334, 4, 1, 123, 12312, 53, 312312, 44, 22, 1134, 455 };


for (int i = 0; i < numeros.Length; i++)
{
    int iMenor = i;

    //0, 1
    //7, 40
    for (int j = i + 1; j < numeros.Length; j++)
    {
        if (numeros[j] < numeros[iMenor])
        {
            iMenor = j;
        }
    }

    int aux = numeros[i];
    numeros[i] = numeros[iMenor];
    numeros[iMenor] = aux;
}


foreach (var item in numeros)
{
    Console.WriteLine(item);
}