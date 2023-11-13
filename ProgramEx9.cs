/*
 
Escreva um programa que leia três valores para os lados de um triângulo (variáveis A, B e C). 

Verificar se cada lado é menor que a soma dos outros dois lados. 

Se sim, saber de A==B e se B==C, sendo verdade o triângulo é eqüilátero; Se não, verificar de A==B ou se A==C ou se B==C, sendo verdade o triângulo é isósceles; e caso 
contrário, o triângulo será escaleno. 

Caso os lados fornecidos não caracterizarem um triângulo, avisar a ocorrência. 

*/
static void main()
{
    Console.Write("Insira o valor do primeiro lado do triângulo --> ");
    string primeiroLado = Console.ReadLine()!;
    int primeiroLadoInt = int.Parse(primeiroLado);

    Console.Write("Insira o valor do segundo lado do triângulo --> ");
    string segundoLado = Console.ReadLine()!;
    int segundoLadoInt = int.Parse(segundoLado);

    Console.Write("Insira o valor do terceiro lado do triângulo --> ");
    string terceiroLado = Console.ReadLine()!;
    int terceiroLadoInt = int.Parse(terceiroLado);

    if (verificarTriangulo(primeiroLadoInt, segundoLadoInt, terceiroLadoInt))
    {
        if(primeiroLadoInt == segundoLadoInt && segundoLadoInt == terceiroLadoInt)
        {
            Console.WriteLine("\n\nTriângulo Equilatero.");
        } else if (primeiroLadoInt == segundoLadoInt || primeiroLadoInt == terceiroLadoInt || segundoLadoInt == terceiroLadoInt)
        {
            Console.WriteLine("\n\nTriângulo Isósceles.");
        }else
        {
            Console.WriteLine("Triângulo Escaleno.");
        }
    }

    static bool verificarTriangulo(double a, double b, double c)
    {
        return a + b > c && a + c > b && b + c > a;
    }

}
main();