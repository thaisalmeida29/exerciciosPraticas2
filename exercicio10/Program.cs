// See https://aka.ms/new-console-template for more information
/*
 * Faça um programa no VS que receba dados de dois atletas (nome, idade e altura).
 * O programa deve mostrar os dados do atleta mais novo e mais alto.
 */



// variaveis
string nomeAtleta1, nomeAtleta2;
int idadeAtleta1, idadeAtleta2;
double alturaAtleta1, alturaAtleta2;

// ler os dados dos atletas

Console.Write("Nome do atleta 1: ");
nomeAtleta1 = Console.ReadLine();

Console.Write("Nome do atleta 2: ");
nomeAtleta2 = Console.ReadLine();

Console.Write("Idade do atleta 1: ");
idadeAtleta1 = int.Parse(Console.ReadLine());

Console.Write("Idade do atleta 2: ");
idadeAtleta2 = int.Parse(Console.ReadLine());

Console.Write("Altura do atleta 1: ");
alturaAtleta1 = double.Parse(Console.ReadLine());
Console.Write("Altura do atleta 2: ");
alturaAtleta2 = double.Parse(Console.ReadLine());

// testa as condições dos atletas usando o operador &&

if (idadeAtleta1 < idadeAtleta2 && alturaAtleta1 > alturaAtleta2)
{
    Console.WriteLine("O atleta 1 é o mais novo e o mais alto.");
}
else if (idadeAtleta2 < idadeAtleta1 && alturaAtleta2 > alturaAtleta1)
{
    Console.WriteLine("O atleta 2 é o mais novo e o mais alto.");

}
