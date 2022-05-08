// See https://aka.ms/new-console-template for more information
/*
 * Escreva um algoritmo que leia 3 valores pelo teclado e então informe qual o maior deles.
 */


// variaveis

int val1, val2, val3, maiorNumero;

// pede 3 valores ao usuario

Console.Write("Digite o primeiro valor: ");
val1 = int.Parse(Console.ReadLine());

Console.Write("Digite o segundo valor: ");
val2 = int.Parse(Console.ReadLine());

Console.Write("Digite o terceiro valor: ");
val3 = int.Parse(Console.ReadLine());


// testa qual numero é maior

if (val1 > val2)
{
    if (val1 > val3)
    {
        maiorNumero = val1;
    }
    else
    {
        maiorNumero = val3;
    }
}
else
{
    if (val2 > val3)
    {
        maiorNumero = val2;
    }
    else
    {
        maiorNumero = val3;
    }
}

Console.WriteLine("O maior número é o: " + maiorNumero);
