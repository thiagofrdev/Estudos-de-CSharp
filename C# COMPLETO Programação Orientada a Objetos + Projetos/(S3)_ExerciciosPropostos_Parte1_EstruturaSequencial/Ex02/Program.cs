/*
Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro casas decimais conforme exemplos.
Fórmula da área: area = π . raio2
Considere o valor de π = 3.14159
*/
Console.Write("Valor do raio: ");
double raio = int.Parse(Console.ReadLine());
double pi = 3.14159;

Console.Write($"A aérea do círculo é {pi*Math.Pow(raio, 2):F2}");