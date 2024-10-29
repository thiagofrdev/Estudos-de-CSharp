//Fazer um programa para ler os valores da largura e altura de um retângulo. Em seguida, mostrar na tela o valor de sua área, perímetro e diagonal. Usar uma classe como mostrado no projeto ao lado.
using System.Globalization;

Retangulo r = new Retangulo();

Console.Write("Largura do retângulo: ");
r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Altura do retângulo: ");
r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write(r.ToString());