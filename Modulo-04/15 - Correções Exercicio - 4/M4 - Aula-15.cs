//(Somar Numeros)
//Escreva um programa que some todos os numeros introduzidos pelo usuario.
//A introducao deve terminar quando o usuario introduzir o numero 0.

//Usar Do While.

double numeroDigitado = 0, totalSoma = 0;

do
{
    Console.WriteLine("Digite um numero para ser somado");
    numeroDigitado = Convert.ToDouble(Console.ReadLine());

    totalSoma += numeroDigitado;

} while (numeroDigitado != 0);

Console.WriteLine($"O total da soma: {totalSoma}");