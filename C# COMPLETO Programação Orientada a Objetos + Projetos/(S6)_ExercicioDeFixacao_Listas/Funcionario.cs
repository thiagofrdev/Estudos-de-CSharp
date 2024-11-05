public class Funcionario
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public double Salario { get; set; }

    public Funcionario (int id, string nome, double salario){
        Id = id;
        Nome = nome;
        Salario = salario;
    }

    public void aumentarSalario(double porcentagem){
        Salario += Salario*(porcentagem/100);
    }

    public override string ToString(){
        return $"({Id}) {Nome} - R${Salario}";
    }
}