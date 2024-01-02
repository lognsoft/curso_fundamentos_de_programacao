
// A fórmula do IMC faz uma relação do peso com a altura ao quadrado do indivíduo, ou seja, sugere dividir o peso 
// pela altura multiplicada por ela mesma. Veja:
// IMC = Peso ÷ (Altura × Altura)
// Exemplo de como calcular o IMC em uma pessoa de 1,60 m de altura e 60 kg:
// IMC = 60 ÷ (1, 60 × 1,60) = 23,43 kg / m²

// IMC	CLASSIFICAÇÃO	OBESIDADE (GRAU) 
// MENOR QUE 18,5	MAGREZA	0
// ENTRE 18,5 E 24,9	NORMAL	0
// ENTRE 25,0 E 29,9	SOBREPESO	I
// ENTRE 30,0 E 39,9	OBESIDADE	II
// MAIOR QUE 40,0	OBESIDADE GRAVE	III

//IMPORTANTE!
//USAR ENUMERADORES PARA LISTAR TODOS GRAUS "ENUMERADOR" EX: (Graus.Magreza)
//CRIAR UM LOOPING USANDO RECURSIVIDADE PARA CALCULAR UM NOVO IMC ATE QUE O USUARIO DIGITE 0.
//EXIBIR NA TELA CADA RESULTADO ANTES DE UMA NOVA SOLICITACAO.


void calcIMC()
{
    Console.WriteLine("Digite a sua altura");
    double altura = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Digite o seu peso");
    double peso = Convert.ToDouble(Console.ReadLine());

    if (peso != 0 && altura != 0)
    {
        double IMC = peso / (altura * altura);

        // MENOR QUE 18,5	MAGREZA	0
        // ENTRE 18,5 E 24,9	NORMAL	0
        // ENTRE 25,0 E 29,9	SOBREPESO	I
        // ENTRE 30,0 E 39,9	OBESIDADE	II
        // MAIOR QUE 40,0	OBESIDADE GRAVE	III

        Console.WriteLine("***********************");
        if (IMC < 18.5)
        {
            Console.WriteLine(Graus.MAGREZA);
        }
        else if (IMC > 18.5 && IMC < 24.9)
        {
            Console.WriteLine(Graus.NORMAL);
        }
        else if (IMC > 25.0 && IMC < 29.9)
        {
            Console.WriteLine(Graus.SOBREPESO);
        }
        else if (IMC > 30.0 && IMC < 39.9)
        {
            Console.WriteLine(Graus.OBESIDADE);
        }
        else
        {
            Console.WriteLine(Graus.OBESIDADEGRAVE);
        }
        Console.WriteLine("***********************");
        Console.WriteLine("Total: " + IMC);
        calcIMC();
    }
    else
    {
        Console.WriteLine("Programa finalizado");
    }
}

calcIMC();


enum Graus { MAGREZA, NORMAL, SOBREPESO, OBESIDADE, OBESIDADEGRAVE }


