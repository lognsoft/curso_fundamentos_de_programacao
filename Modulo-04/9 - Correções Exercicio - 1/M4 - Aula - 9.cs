//FOR
//Um número primo é aquele que é dividido apenas por um e por ele mesmo.
//Escreva um programa para avaliar se o numero que o usuario digitou
//E um numero primo ou nao.


// 6 / 6 = 1 = 0
// 6 /2 = 3 = 0
// 6 / 3 = 2 = 0
// 6/ 2 = 3 = 0
//6 /1 = 6 = 0

//3/1 = 3
// 3 /2 = 
//3/3 = 1

bool primo = true;

Console.WriteLine("Digite um numero");
int numeroDigitado = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i < numeroDigitado; i++)
{
    if (numeroDigitado % i == 0)
    {
        primo = false;
    }
}

if (primo == true)
{
    Console.WriteLine("Este e um numero primo");
}
else
{
    Console.WriteLine("Este nao e um numero primo");
}

