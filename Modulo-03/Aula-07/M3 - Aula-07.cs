System.Console.WriteLine("Digite o seu tipo de conta");
System.Console.WriteLine("--------------------------");
System.Console.WriteLine("3 - Pessoa fisica");
System.Console.WriteLine("4 - Pessoa juridica");

int tipoUsuario = Convert.ToInt32(Console.ReadLine());

if (tipoUsuario == (int)tiposConta.Fisica)
{
    System.Console.WriteLine("Voce pode sacar ate 2.000 reais");
}
else
{
    System.Console.WriteLine("Voce pode sacar ate 10.000 reais");
}

enum tiposConta { Fisica = 3, Juridica = 4 };

// const int domingo = 0;
// const int segunda = 1;
// const int terca = 2;
// const int quarta = 3;
// const int quinta = 4;
// const int sexta = 7;
// const int sabado = 6;

// if (quarta == 3)
// {
//     System.Console.WriteLine("Quarta");
// }
// if (segunda == 1)
// {
//     System.Console.WriteLine("Segunda");
// }
// if (sabado == 6)
// {
//     System.Console.WriteLine("SAbado");
// }