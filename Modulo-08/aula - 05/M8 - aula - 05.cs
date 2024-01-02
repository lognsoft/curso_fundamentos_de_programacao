//Escreva um programa que calcule a media de numeros inteiros
//O programa devera validar a entrada dos numeros inteiros.
//Caso o numero nao seja inteiro, nao deve ser contabilizado no calculo de media
//E devera enviar uma mensagem de erro.
//A cada vez que for inserido um novo numero, enviar uma mensagem avisando
//Que o numero foi salvo com sucesso!
//Exibir o resultado da media de 5 numeros

int totalMedia = 0;
int i = 0;

while (i < 5)
{
    try
    {
        Console.WriteLine("Por favor digite um numero");
        int numero = Convert.ToInt32(Console.ReadLine());
        totalMedia += numero;
        i++;
        Console.WriteLine("Numero salvo com sucesso!");
        Console.WriteLine("-------------------------------------");
    }
    catch (System.Exception ex)
    {
        Console.WriteLine("Por favor digite um numero, letras nao sao aceitas");
    }
}

Console.WriteLine("Media: " + totalMedia / 5);

