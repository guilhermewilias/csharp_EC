/*
 
Escreva um programa que leia um número inteiro. 
Verificar por meio de condição se o valor fornecido está na faixa 
entre 0 (zero) e 9 (nove). Caso o valor fornecido esteja dentro da faixa, apresentar a mensagem “valor válido”. 
Caso contrário, apresentar a mensagem “valor inválido”. 

*/

static void main()
{
    Console.Write("Insira um número inteiro --> ");
    string numero = Console.ReadLine()!;
    int numeroInt = int.Parse(numero);

    if (numeroInt >= 0 && numeroInt <= 9){
        Console.Write("\n\nValor válido.\n\n\n\n");
    }
    else
    {
        Console.Write("\n\nValor inválido.\n\n\n\n");
    }

}

main();