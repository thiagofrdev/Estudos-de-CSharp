//Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano (primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno no ano. Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam para o aluno obter o mínimo para ser aprovado (que é 60 pontos). Você deve criar uma classe Aluno para resolver este problema.
using System.Globalization;

Aluno a = new Aluno();

Console.Write("Nome: ");
a.Nome = Console.ReadLine();

for(int i = 0; i < 3; i++){
    Console.Write($"Escreva a {i+1}ª nota: ");
    a.Notas[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
}

Console.Write(a.ToStringResultado(), CultureInfo.InvariantCulture);