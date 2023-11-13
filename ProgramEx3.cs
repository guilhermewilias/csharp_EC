/*
Modulo 02 - Estrutura condicionais.

Exercicio 3 -)
Escreva um programa que leia 3 números inteiros e imprima na tela os valores em ordem decrescente.
*/

static void main()
{
    Console.Write("Digite primeiro número --> ");
    string numeroUm = Console.ReadLine()!;
    int numeroUmInt = int.Parse(numeroUm);

    Console.Write("\n\nDigite o segundo número --> ");
    string numeroDois = Console.ReadLine()!;
    int numeroDoisInt = int.Parse(numeroDois);

    Console.Write("\n\nDigite o terceiro número --> ");
    string numeroTres = Console.ReadLine()!;
    int numeroTresInt = int.Parse(numeroTres);

    int[] numerosOrdenados = ordenarCrescente(numeroUmInt, numeroDoisInt, numeroTresInt);

    Console.WriteLine($"Números em ordem decrescente : {numeroTresInt},{numeroDoisInt},{numeroUmInt}", numerosOrdenados[0], numerosOrdenados[1], numerosOrdenados[2]);


    static int [] ordenarCrescente(int a, int b, int c)
    {
        int[] numeros = { a, b, c };

        Array.Sort(numeros);
        Array.Reverse(numeros);

        return numeros;
    }
}

main();