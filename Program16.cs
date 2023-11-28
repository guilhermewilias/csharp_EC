/*
 Faça um programa que leia um número. Se positivo armazene-o em A, se for negativo, em B. No final mostrar o 
resultado. 
 */

static void main()
{

    Console.WriteLine("Por favor, digite um número : ");
    int numero = int.Parse(Console.ReadLine()!);

    if (numero >= 0)
    {
        Console.WriteLine($"O número {numero} é positivo. Foi armazenado em A.");
        int A = numero;
    }
    else
    {
        Console.WriteLine($"O número {numero} é negativo. Foi armazenado em B.");
        int B = numero;
    }
    
}
main();
