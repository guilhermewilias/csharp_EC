/*

Modulo 02 - Estrutura condicionais.

Exercicio 4 -)
Escreva um programa que leia dois números e apresente a diferença do maior para o menor. 

*/

static void main()
{
    Console.Write("Digite o primeiro número --> ");
    string primeiroNumero = Console.ReadLine()!;
    int primeiroNumeroInt = int.Parse(primeiroNumero)!;

    Console.Write("\nDigite o segundo número --> ");
    string segundoNumero = Console.ReadLine()!;
    int segundoNumeroInt = int.Parse(segundoNumero)!;

    double diferenca = calcularDiferenca(primeiroNumeroInt, segundoNumeroInt);

    Console.WriteLine($"\n\nA diferença do maior número para o menor número é {diferenca}");

    static double calcularDiferenca(double x, double y)
    {
        double maior = Math.Max(x, y);
        double menor = Math.Min(x, y);
        return maior - menor;
    }

}

main();