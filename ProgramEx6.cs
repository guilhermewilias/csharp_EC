/* 

Escreva um programa que leia dois números e exiba mensagem informando o valor do maior número e o valor do 
menor número. 
Se os dois números forem iguais, o programa deve exibir mensagem informando este fato. 

*/

static void main()
{ 
    Console.Write("Insira o primeiro número --> ");
    string primeiroNum = Console.ReadLine()!;
    int primeiroNumInt = int.Parse(primeiroNum);

    Console.Write("\nInsira o segundo número --> ");
    string segundoNum = Console.ReadLine()!;
    int segundoNumInt = int.Parse(segundoNum);

    if (primeiroNumInt > segundoNumInt)
    {
        Console.Write($"\nO maior número : {primeiroNum}\nO menor número : {segundoNumInt}");
    } else if (segundoNumInt > primeiroNumInt)
    {
        Console.Write($"\nO maior número : {segundoNumInt}\nO menor número : {primeiroNumInt}");
    }
    else
    {
        Console.Write($"Ambos os números são iguais! E são : {primeiroNumInt}");
    }
}


main();