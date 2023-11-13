/* 
 
Modulo 02 - Estrutura condicionais.

Exercicio 1 -)
Escreva um programa que leia um número inteiro e exiba o seu módulo. 
O módulo de um número x é: 

x se x é maior ou igual a zero 
x * (-1) se x é menor que zero

*/

static void main()
{
    Console.Write("Insira um número inteiro --> ");
    string numero = Console.ReadLine();
    int numeroINT = int.Parse(numero);

    int calculoModulo = modulo(numeroINT);
    Console.WriteLine($"O modulo do numero {numeroINT} é {calculoModulo}\n\n\n\n");

    static int modulo(int x)
    {
        return x >= 0 ? x : x * (-1);
    }
}

main();