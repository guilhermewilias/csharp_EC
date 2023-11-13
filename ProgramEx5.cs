/*
Modulo 02 - Estrutura condicionais.

Exercicio 4 -)

Escreva um programa que leia quatro notas escolares de um aluno.

Apresentar uma mensagem que o aluno foi aprovado se o valor da média escolar for maior ou igual a 7. 

Se o valor da média for menor que 7, solicitar a nota do recuperação, somar com o valor da média e obter a nova média. 

Se a nova média for maior ou igual a 7, apresentar uma mensagem informando que o aluno foi aprovado na recuperação. 

Se o aluno não foi aprovado, apresentar uma mensagem informando esta condição. Apresentar junto com as mensagens o valor da média do 
aluno.

*/

using System.ComponentModel.Design;

static void main()
{
    Console.Write("Digite a primeira nota do aluno --> ");
    string notaUm = Console.ReadLine()!;
    double notaUmInt = double.Parse(notaUm);

    Console.Write("\nDigite a segunda nota do aluno --> ");
    string notaDois = Console.ReadLine()!;
    double notaDoisInt = double.Parse(notaDois);

    Console.Write("\nDigite a terceira nota do aluno --> ");
    string notaTres = Console.ReadLine()!;
    double notaTresInt = double.Parse(notaTres);

    Console.Write("\nDigite a quarta nota do aluno --> ");
    string notaQuatro = Console.ReadLine()!;
    double notaQuatroInt = double.Parse(notaQuatro);

    double mediaNotas = (notaUmInt + notaDoisInt + notaTresInt + notaQuatroInt)/4;

    if (mediaNotas > 7)
    {
        Console.Write("\n\n\nAluno aprovado. Parabéns!\n\n\n");
    }

    if (mediaNotas < 7)
    {
        Console.Write("\n\nDigite a nota da recuperação --> ");
        string notaRec = Console.ReadLine()!;
        double notaRecInt = double.Parse(notaRec);
        double mediaPosRec = (notaRecInt + mediaNotas) / 2;

        if (mediaPosRec > 7)
        {
            Console.Write($"\n\n\nAluno aprovado na recuperação. Média pós rec foi : {mediaPosRec}. Parabéns!\n\n\n");
        }
        else
        {
            Console.Write($"\n\n\nA média pós rec foi : {mediaPosRec}! Aluno reprovado!\n\n\n");
        }
    }

}

main();
