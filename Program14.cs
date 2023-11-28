/*
Escrever um programa declarando três variáveis do tipo inteiro (a, b e c). Ler um valor maior que zero para cada 
variável (se o valor digitado não é válido, mostrar mensagem e ler novamente). Exibe o menor valor lido 
multiplicado pelo maior e o maior valor dividido pelo menor.
*/

static void main()
{
    int a, b, c;

    do //Lendo um número maior que zero para A.
    {
        Console.WriteLine("Digite um valor inteiro maior que zero --> ");
        a = int.Parse(Console.ReadLine()!);

    } while (a <= 0); //Validação para ver que é maior que zero 

    do //Lendo um número maior que zero para B.
    {
        Console.WriteLine("\nDigite um segundo valor inteiro maior que zero --> ");
        b = int.Parse(Console.ReadLine()!);
    } while (b <= 0);//Validação para ver que é maior que zero 


    do //Lendo um número maior que zero para B.
    {
        Console.WriteLine("\nDigite um terceiro valor inteiro maior que zero --> ");
        c = int.Parse(Console.ReadLine()!);
    } while (c <= 0);//Validação para ver que é maior que zero 



    int menor = a;
    if (b < menor)
    {
        menor = b;
    }if (c < menor)
    {
        menor = c;
    }

    int maior = a;
    if (a > maior)
    {
        maior = b;
    } if (c > maior)
    {
        maior = c;
    }

    int menorMulti = menor * maior;
    int maiorDiv = maior / menor;

    Console.WriteLine($"\n\nO menor valor lido multiplicado pelo maior é {menorMulti}", menor * maior);
    Console.WriteLine($"\n\nO maior valor lido dividido pelo menor é {maiorDiv}", maior / menor);
}

main();
