// Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.
using System.Globalization;

Console.Write("Produto 1 (nome qtd preço): ");
string[] produto1 = Console.ReadLine().Split(" ");
Console.Write("Produto 2 (nome qtd preço): ");
string[] produto2 = Console.ReadLine().Split(" ");

Console.Write("Total a pagar = R$" + (int.Parse(produto1[1])*double.Parse(produto1[2], CultureInfo.InvariantCulture) + int.Parse(produto2[1])*double.Parse(produto2[2], CultureInfo.InvariantCulture)));