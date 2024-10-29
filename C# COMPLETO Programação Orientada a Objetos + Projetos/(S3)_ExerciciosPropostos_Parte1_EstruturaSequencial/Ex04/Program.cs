// Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas decimais.
using System.Globalization;

Console.Write("Número: ");
int numero = int.Parse(Console.ReadLine());
Console.Write("Hrs. trabalhadas: ");
int horasTrabalhadas = int.Parse(Console.ReadLine());
Console.Write("Val. por hora: ");
double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write($"NUMBER = {numero}\nSALARY = U${horasTrabalhadas*valorHora:F2}");