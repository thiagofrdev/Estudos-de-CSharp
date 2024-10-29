// Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário médio dos funcionários.
Funcionario fA, fB;

fA = new Funcionario(); 
fB = new Funcionario();

Console.WriteLine("Dados do primeiro funcionário:");
Console.Write("Nome: ");
fA.nome = Console.ReadLine();
Console.Write("Salário: ");
fA.salario = double.Parse(Console.ReadLine());

Console.WriteLine("Dados do segundo funcionário:");
Console.Write("Nome: ");
fB.nome = Console.ReadLine();
Console.Write("Salário: ");
fB.salario = double.Parse(Console.ReadLine());

Console.Write("Salário médico = R$" + Funcionario.mediaSalario(fA.salario, fB.salario));