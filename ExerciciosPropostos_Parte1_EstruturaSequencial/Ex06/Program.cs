/*Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e
mostre:
a) a área do triângulo retângulo que tem A por base e C por altura.
b) a área do círculo de raio C. (pi = 3.14159)
c) a área do trapézio que tem A e B por bases e C por altura.
d) a área do quadrado que tem lado B.
e) a área do retângulo que tem lados A e B.
*/
using System.Globalization;

Console.Write("Insira os valores de A, B e C dessa forma -> (A B C)): ");
string[] valores = Console.ReadLine().Split(" ");

double A = double.Parse(valores[0], CultureInfo.InvariantCulture);
double B = double.Parse(valores[1], CultureInfo.InvariantCulture);
double C = double.Parse(valores[2], CultureInfo.InvariantCulture);

double aeraTriangulo = (float) (A*C)/2;
double aeraCrirculo = (float) C*3.14159;
double areaTrapezio = (float) ((A+B)*C)/2;
double areaQuadrado = (float) Math.Pow(B, 2);
double aeraRetangulo = (float) A*B;

Console.Write($"TRIANGULO = {aeraTriangulo:F3}\nCIRCULO = {aeraCrirculo:F3}\nTRAPÉZIO = {areaTrapezio:F3}\nQUADRADO = {areaQuadrado:F3}\nRETÂNGULO = {aeraRetangulo:F3}");