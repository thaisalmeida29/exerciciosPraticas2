
// See https://aka.ms/new-console-template for more information
/*
 * Faça um programa no VS que receba do usuário 3 valores de glicemia em jejum, representando a medição
 * diária de um paciente diabético. Para cada valor recebido analisar e informar ao paciente o seguinte:
 * Se o valor diário for menor que 65, avisá-lo que corre risco de hipoglicemia
 * Se o valor diário for maior que 250, avisá-lo que corre risco de hiperglicemia.
 * Além disso, o programa deve fazer a média dos 3 valores de glicemia coletados. 
 * E se a média for menor que 80, avisá-lo que é preciso diminuir 2 unidades de insulina.
 * Se a média for maior que 150, avisá-lo que será necessário adicionar 2 unidades de insulina.
 */

// variaveis

double glicemia1, glicemia2, glicemia3, media;  

// ler do usuario o valor das variaveis

Console.Write("Digite o primeiro valor da sua glicemia em jejum: ");
glicemia1 = double.Parse(Console.ReadLine());

Console.Write("Digite o segundo valor da sua glicemia em jejum: ");
glicemia2 = double.Parse(Console.ReadLine());

Console.Write("Digite o terceiro valor da sua glicemia em jejum: ");
glicemia3 = double.Parse(Console.ReadLine());

// faz a soma das medias

media = (glicemia1 + glicemia2 + glicemia3) / 3;

// testa as condições

if (glicemia1 < 65 || glicemia2 < 65 || glicemia3 < 65)
{
    Console.WriteLine("Você corre risco de hipoglicemia");
}
else if (glicemia1 > 250 || glicemia2 > 250 || glicemia3 > 250)
{
    Console.WriteLine("Você corre risco de hiperglicemia.");
}
if (media < 80)
{
    Console.WriteLine(" A media das suas glicemias é: " + media + " é preciso diminuir 2 unidades de insulina.");
}
else if (media > 150)
{
    Console.WriteLine(" A media das suas glicemias é: " + media + " é preciso aumentar 2 unidades de insulina.");
}
