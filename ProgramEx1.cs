/*
Modulo 02 - Estrutura condicionais.

Exercicio 1 -) 
Ler dois valores inteiros para as variáveis A e B, efetuar a troca dos valores de modo que a variável A passe a 
possuir o valor da variável B, e a variável B passe a possuir o valor da variável A. Apresentar os valores trocados
*/
static void main()
{
    Console.Write("Digite o valor de a --> ");
    string a = Console.ReadLine();
    int aNum = int.Parse(a);

    Console.Write("Digite o valor de b --> ");
    string b = Console.ReadLine();
    int bNum = int.Parse(b);

    trocaDeValores (ref aNum, ref bNum);

    Console.WriteLine($"\n\nValores trocados são : A = {aNum}, B = {bNum}\n\n\n");

    static void trocaDeValores(ref int x, ref int y)
    {
        int temp = x;
        x = y; 
        y = temp;
    }
}

main();