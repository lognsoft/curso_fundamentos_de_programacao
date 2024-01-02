using System.Text;

//Escreva um metodo que capture a ultima palavra da frase (Bem vindo ao meu programa);
//Exiba a palavra na tela com a primeira letra em caixa alta, por exemplo "Programa";
//IMPORTANTE USAR STRINGBUILDER para concatenar as strings.

StringBuilder sb = new StringBuilder();

string frase = "Bem vindo ao meu programa";
int posicao = 0;

for (int i = 0; i < frase.Length; i++)
{
    if (frase[i] == ' ')
    {
        posicao = i + 1;
    }
}

bool primeiraLetra = true;
while (posicao < frase.Length)
{
    if (primeiraLetra)
    {
        sb.Append(frase[posicao].ToString().ToUpper());
        primeiraLetra = false;
    }
    else
    {
        sb.Append(frase[posicao]);
    }
    posicao++;
}

Console.WriteLine(sb);