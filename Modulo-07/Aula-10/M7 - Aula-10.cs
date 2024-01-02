//Escreva um metodo que devolva quantas vezes um caracter 
//aparece na string = "Bem vindo ao meu programa".Caso o caracter nao exista, devera devolver uma mensagem
//avisando que nao foi encontrado nenhum caracter.

string frase = "Bem vindo ao meu programa";

void encontraCaracter(string frase)
{
    int contadorLetras = 0;
    string msg = "";

    Console.WriteLine("Digite um caracter para ser encontrado na frase (Bem vindo ao meu programa)");
    char caracterDigitado = Convert.ToChar(Console.ReadLine());

    for (int i = 0; i < frase.Length; i++)
    {
        if (caracterDigitado == frase[i])
        {
            contadorLetras += 1;
        }
    }

    msg = contadorLetras != 0 ? $"Total de caracteres encontrados: {contadorLetras} - caracter {caracterDigitado}" : $"nao foi encontrado nenhum caracter {caracterDigitado}";

    Console.WriteLine(msg);
}

encontraCaracter(frase);