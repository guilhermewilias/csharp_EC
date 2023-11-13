/* 

Escrever um programa declarando três variáveis do tipo inteiro (a, b e c). 

Ler um valor maior que zero para cada variável (se o valor digitado não é válido, mostrar mensagem e ler novamente). 

Exibe o menor valor lido multiplicado pelo maior e o maior valor dividido pelo menor.

*/



    static void Main()
    {
        int a, b, c;

        // Leitura e validação do valor para a variável 'a'
        do
        {
            Console.Write("Digite um valor maior que zero para a variável 'a': ");
        } while (!int.TryParse(Console.ReadLine(), out a) || a <= 0);

        // Leitura e validação do valor para a variável 'b'
        do
        {
            Console.Write("Digite um valor maior que zero para a variável 'b': ");
        } while (!int.TryParse(Console.ReadLine(), out b) || b <= 0);

        // Leitura e validação do valor para a variável 'c'
        do
        {
            Console.Write("Digite um valor maior que zero para a variável 'c': ");
        } while (!int.TryParse(Console.ReadLine(), out c) || c <= 0);

        // Encontrar o menor e o maior valor
        int menor = Math.Min(Math.Min(a, b), c);
        int maior = Math.Max(Math.Max(a, b), c);

        // Exibir o menor valor multiplicado pelo maior
        Console.WriteLine($"Menor valor multiplicado pelo maior: {menor * maior}");

        // Exibir o maior valor dividido pelo menor
        Console.WriteLine($"Maior valor dividido pelo menor: {maior / (double)menor}");

        Console.ReadLine(); // Aguarda a entrada do usuário antes de fechar a aplicação
    }

Main();

