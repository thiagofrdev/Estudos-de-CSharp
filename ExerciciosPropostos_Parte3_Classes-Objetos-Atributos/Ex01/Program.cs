using System.Globalization;

Console.Write("Cotação do Dolar: ");
double cotDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Quantos dólares você vai comprar? ");
double qtdDolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Valor a ser pago em reais = R$" + Conversor.RealToDolar(cotDolar, qtdDolares));