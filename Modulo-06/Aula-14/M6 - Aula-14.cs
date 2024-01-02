//Escreva um programa que apresente o indice em 
//que se encontra o numero a pesquisar.
//Exemplo: v= {3,2,7,4,8,10}, valor a pesquisar: 8
//Resultado indice: 4
//Caso nao encontre o numero, deve mostrar a mensagem,
//numero nao encontrado
//caso encontre o numero, deve mostrar a mensagem.
//Numero se encontra no indice: 4

int[] v = new int[] { 3, 2, 7, 4, 8, 10 };

Console.WriteLine("Digite um numero para ser encontrado");
int numeroDigitado = Convert.ToInt32(Console.ReadLine());
int encontrado = -1;
string msg;

for (int i = 0; i < v.Length; i++)
{
    if (numeroDigitado == v[i])
    {
        encontrado = i;
    }
}
msg = encontrado == -1 ? "numero nao encontrado" : $"Numero se encontra no indice: {encontrado}";

Console.WriteLine(msg);