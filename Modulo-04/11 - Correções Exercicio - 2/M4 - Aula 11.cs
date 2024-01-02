//Escreva um programa que apresente na tela 
//O numero de votos em tres candidatos distintos
//Quantidade de votantes: Deve ser escolhido pelo usuario do programa.
//Candidatos A,B e C.

//Dica - Usar Switch Case
//Usar - For

int A = 0, B = 0, C = 0, Votantes = 0;

Console.WriteLine("Escolha a quantidade de vontantes");
Votantes = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < Votantes; i++)
{
    Console.WriteLine("Escolha um candidato: A, B ou C");
    string voto = Console.ReadLine();
    switch (voto)
    {
        case "A":
            A += 1;
            break;
        case "B":
            B += 1;
            break;
        case "C":
            C += 1;
            break;
        default:
            Console.WriteLine("nenhum candidato encontrado");
            break;
    }
}

Console.WriteLine($"Canditos - A:{A} B:{B} C:{C}");

if (A > B && A > C)
{
    Console.WriteLine("Canditato A vencedor");
}
else if (B > A && B > C)
{
    Console.WriteLine("Canditato B vencedor");
}
else
{
    Console.WriteLine("Canditato C vencedor");
}

