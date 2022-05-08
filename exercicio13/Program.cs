// See https://aka.ms/new-console-template for more information

/*
 * Tendo como dado de entrada a altura (h) de uma pessoa, construa um programa no VS que calcule 
seu peso ideal, utilizando as seguintes fórmulas:
Para homens: (72.7 * h) - 58
Para mulheres: (62.1 * h) - 44.7
 */

// variaveis

double h, peso;
string sexo;

// pede a altura e o sexo do usuario 
Console.Write("Digite sua altura: ");
h = double.Parse(Console.ReadLine());
Console.Write("Digite seu sexo: ");
sexo = Console.ReadLine();  


if (sexo.Contains("masculino") == true)
{
    peso = (72.7 * h) - 58;
    Console.WriteLine("O peso ideal de um homem é: " + peso + "Kg");
}
else if (sexo.Contains("femenino") == true)
{
    peso = (62.1 * h) - 44.7;
    Console.WriteLine("O peso ideal de uma mulher é: " + peso + "Kg");
}

