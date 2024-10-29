//Numero da conta, titular, Perguntar se haverá deposito inicial, valor de deposito inicial -> mostrar dados da conta -> Perguntar valor para depósito e mostrar dados atualizados -> Perguntar valor para saque e mostrar dados atualizados (Saque tem uma taxa de R$5)
Random numeroConta = new Random();
Conta conta;

int numero = numeroConta.Next(1000,9999);
Console.Write("Nome: ");
string nome = Console.ReadLine();
Console.Write("Deposito inicial (s/n): ");
if (Console.ReadLine() == "s"){
    Console.Write("Insira o valor: ");
    double deposito = double.Parse(Console.ReadLine());
    conta = new Conta(numeroConta.Next(1000,9999), nome, deposito);
} else {
    conta = new Conta(numeroConta.Next(1000,9999), nome);
}

Console.WriteLine(conta);

Console.Write("Valor para depósito: ");
conta.Deposito(double.Parse(Console.ReadLine()));

Console.WriteLine(conta);

Console.Write("Valor para saque: ");
conta.Saque(double.Parse(Console.ReadLine()));

Console.WriteLine(conta);