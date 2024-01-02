//Escreva um programa que exiba o menor numero de um conjunto de numeros digitados
//Pelo usuario a introducao dos numeros terminara quando for inserido o numero 0.

int numeroDigitado, menorNumero;

Console.WriteLine("Digite um numero");
numeroDigitado = Convert.ToInt32(Console.ReadLine());
menorNumero = numeroDigitado;

while (numeroDigitado != 0)
{
    Console.WriteLine("Digite um numero");
    numeroDigitado = Convert.ToInt32(Console.ReadLine());

    if (menorNumero > numeroDigitado && numeroDigitado != 0)
    {
        menorNumero = numeroDigitado;
    }
}

Console.WriteLine("Menor numero " + menorNumero);



