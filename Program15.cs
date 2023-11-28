/*
Faça um programa que leia um número inteiro e mostre uma mensagem na tela indicando se este número é 
positivo ou negativo. Pare a execução do programa quando o usuário requisitar.
*/

static void main()
{
    Console.WriteLine("Escreva um número inteiro --> ");
    string numero = Console.ReadLine()!;
    int numeroInt = int.Parse(numero);  

    if (numeroInt > 0)
    {
        Console.WriteLine($"\n\nO número {numeroInt} é positivo");
    }else if (numeroInt < 0)
    {
        Console.WriteLine($"\n\nO número {numeroInt} é negativo");
    }
    else
    {
        Console.WriteLine("\n\nO numero digitado é zero", numeroInt);
    }

    Console.WriteLine("\n\nDeseja continuar (digite sim para continuar e não para fechar o programa.)");
    string resposta = Console.ReadLine()!.ToUpper();

    while (resposta != "não")
    {
        Console.WriteLine("Programa encerado, tecle qualquer coisa para fechar o console!");
        break;
    }
}
main();