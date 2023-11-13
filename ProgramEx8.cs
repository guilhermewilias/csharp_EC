/*

Escreva um programa que leia um número inteiro (variável CODIGO). 

Verificar se o código é igual a 1, igual a 2 ou igual a 3. Caso não seja, apresentar a mensagem “Código inválido”. 

Ao ser verificado o código e constatado que é um valor válido, o programa deve verificar cada código em separado para determinar seu valor por extenso, ou 
seja, apresentar a mensagem “um”, ”dois” ou “três”. (Utilizar o comando Switch).

*/

using System.Net.Http.Headers;

static void main()
{
    Console.Write("Insira um número inteiro --> ");
    string variavelCodigo = Console.ReadLine()!;
    int variavelCodigoInt = int.Parse(variavelCodigo);

    switch (variavelCodigoInt)
    {
        case 1:
            Console.WriteLine("\n\nUm");
            break;
        case 2: 
            Console.WriteLine("\n\nDois");
            break; 
        case 3:
            Console.WriteLine("\n\nTrês");
            break;
        default:
            Console.WriteLine("\n\nCódigo inválido");
            break;
    }
    
}

main();