/*
Faça um programa que leia um número. Se positivo armazene-o em A, se for negativo, em B. No final mostrar o 
resultado. 
*/

static void main()
{
   int[] arrayA= new int[1];
   int[] arrayB= new int[1];

    int contadorA = 0;
    int contadorB = 0;

    while (contadorA < arrayA.Length && contadorB < arrayB.Length)
    {
        Console.Write("Digite um número --> ");
        int numero = int.Parse(Console.ReadLine()!);

        if (numero > 0)
        {
            arrayA[contadorA] = numero;
            contadorA++;
        }
        else if (numero < 0)
        {
            arrayB[contadorB] = numero;
            contadorB++;
        }
        else
        {
            Console.WriteLine("O número é 0, por favor digite um número que não seja neutro!");
        }
    }

    Console.WriteLine("\n\nValores armazenados em a :");
    ImprimirArray(arrayA);

    Console.WriteLine("\n\nValores armazenados em b :");
    ImprimirArray(arrayB);

    static void ImprimirArray(int[] array)
    {
        foreach (var numero in array)
        {
            if (numero != 0)
            {
                Console.WriteLine(numero + " ");
            }
            Console.WriteLine();
        }
    }
}
main();