class Conta
{
    public int NumeroConta;
    public string NomeTitular { get; set; }
    public double Saldo { get; private set; }

    public Conta(int numeroConta, string nomeTitular){
        NumeroConta = numeroConta;
        NomeTitular = nomeTitular;
        Saldo = 0.0;
    }

    public Conta(int numeroConta, string nomeTitular, double deposito){
        NumeroConta = numeroConta;
        NomeTitular = nomeTitular;
        Saldo = deposito;
    }

    public void Deposito (double deposito){
        Saldo += deposito;
    }

    public void Saque (double saque){
        Saldo -= saque+5;
    }

    public override string ToString(){
        return $"\nDados da Conta:\nNúmero: {NumeroConta}\nNome: {NomeTitular}\nValor: R${Saldo:F2}\n";
    }
}