//Fazer um programa para ler os valores da largura e altura de um retângulo. Em
//seguida, mostrar na tela o valor de sua área, perímetro e diagonal. Usar uma classe
//como mostrado no projeto ao lado.

using Exercicio03;
using System.Globalization;

Retangulo r = new Retangulo();

Console.WriteLine("Entre com a largura e altura do retângulo:");
r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine($"AREA = {r.Area().ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine($"PERÍMETRO = {r.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine($"DIAGONAL = {r.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");
