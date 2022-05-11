// See https://aka.ms/new-console-template for more information
/*
 * -
 * Faça um programa no VS que receba uma hora, dividida em 2 variáveis (uma para hora e outra para minutos).
 * O programa deve exibir se a hora digitada está ou não válida. 
 * Lembre que usaremos o padrão de hora com 24h, de 0 a 23.
 */

// variaveis

int hora, minutos;
Console.Write("Digite a hora: ");
hora = int.Parse(Console.ReadLine());
Console.Write("Digite os minutos: ");
minutos = int.Parse(Console.ReadLine());

if (hora <= 24 && minutos <= 60)
{
    Console.WriteLine("Hora valida!!");
}
else
{ 
    Console.WriteLine("Hora invalida!!");
}
