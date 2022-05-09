// See https://aka.ms/new-console-template for more information

/*
 * - Escreva um algoritmo para o jogo de adivinhação do número secreto. O
 * jogador tem 3 chances e recebe dicas do tipo “é maior” ou “é menor”. 
 * plus: você pode gerar o número de forma randomica (função random c#).
 */

int num = 0, tentativas = 0;
Random numeroAleatorio = new Random();
int numeroSorteio = numeroAleatorio.Next(1, 10);

while (tentativas != 3)
{
    if (tentativas != 0)
    {
        Console.WriteLine("Tente novamente!!");
    }
    tentativas++;

    Console.Write("Digite um número: ");
    num = int.Parse(Console.ReadLine());

    if (num == numeroSorteio)
    {
        Console.WriteLine("Parabéns você acertou!!");
        break;
    }
    else
    {
        Console.WriteLine($"O número sorteado é {(num > numeroSorteio ? "MENOR" : "MAIOR")} do que você digitou!");   
    }
}

if (num != numeroSorteio)
{
    Console.WriteLine("PERDEU");
}




