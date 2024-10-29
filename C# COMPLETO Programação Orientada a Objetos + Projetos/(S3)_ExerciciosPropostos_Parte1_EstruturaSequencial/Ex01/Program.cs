//Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma mensagem explicativa, conforme exemplos.
Console.Write("Valor 1: ");
int valor1 = int.Parse(Console.ReadLine());
Console.Write("Valor 2: ");
int valor2 = int.Parse(Console.ReadLine());

Console.Write($"SOMA = {valor1+valor2}");