//Escreva um programa que tenha um vetor bidimensional 3x3
//ex: v - { { 3, 4, 5 }, { 6, 5, 4 }, { 2, 3, 9 } }
//Use o for para exibir todos os numeros na tela da seguinte maneira
//345
//654
//239

int[,] Matriz = new int[,] { { 3, 4, 5, 5 }, { 6, 5, 4, 3 }, { 2, 3, 9, 2 }, { 2, 3, 9, 0 } };

int linhas = Matriz.GetLength(0), colunas = Matriz.GetLength(1);

for (int i = 0; i < linhas; i++)
{
    Console.WriteLine();
    for (int j = 0; j < colunas; j++)
    {
        Console.Write(Matriz[i, j]);
    }
}