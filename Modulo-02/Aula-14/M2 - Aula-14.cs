// Escreva um programa que verifique a validade de uma senha fornecida pelo usuário.
// A senha válida é o número 1234. Devem  ser impressas as seguintes mensagens:
// SENHA VALIDA caso a senha seja válida.	
// SENHA INVALIDA caso a senha seja inválida.

string senha = "1234";

Console.WriteLine("Digite a senha");
string senhaDigitada = Console.ReadLine();

if (senha == senhaDigitada)
{
    Console.WriteLine("SENHA VALIDA");
}
else
{
    Console.WriteLine("SENHA INVALIDA");
}