//Fazer um programa para ler os dados de um funcionário (nome,
//salário bruto e imposto). Em seguida, mostrar os dados do
//funcionário (nome e salário líquido). Em seguida, aumentar o salário
//do funcionário com base em uma porcentagem dada (somente o
//salário bruto é afetado pela porcentagem) e mostrar novamente os
//dados do funcionário. Use a classe projetada abaixo.

using Exercicio04;
using System.Globalization;

Funcionario f = new Funcionario();

Console.Write("Nome: ");
f.Nome = Console.ReadLine();
Console.Write("Salário Bruto: ");
f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
Console.Write("Imposto: ");
f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine();
Console.WriteLine($"Funcionário: {f.Nome}, $ {f.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}");

Console.WriteLine();
Console.Write("Digite a porcentagem para aumentar o salário: ");
double porcen = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
f.AumentarSalario(porcen);

Console.WriteLine();
Console.WriteLine($"Dados atualizados: {f}");
