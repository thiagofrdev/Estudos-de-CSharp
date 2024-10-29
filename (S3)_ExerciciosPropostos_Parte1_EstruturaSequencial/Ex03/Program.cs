//Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).
Console.Write("Valor A: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Valor B: ");
int B = int.Parse(Console.ReadLine());
Console.Write("Valor C: ");
int C = int.Parse(Console.ReadLine());
Console.Write("Valor D: ");
int D = int.Parse(Console.ReadLine());

Console.Write($"DIFERENCA = {A*B - C*D}");