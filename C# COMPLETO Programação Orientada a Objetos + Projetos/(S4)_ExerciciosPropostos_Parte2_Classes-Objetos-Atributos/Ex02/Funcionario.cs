class Funcionario{
    public string Nome;
    public double SalarioBruto;
    public double Imposto;


    public string ToStringFuncionario(){
        return $"\nDados do Funcionário:\nNome: {Nome}\nSalário: R${SalarioBruto-Imposto:F2}\n";
    }

    public string ToStringFuncionarioAtualizado(double procentagem){
        double salarioAtualizado = (SalarioBruto-Imposto)+(SalarioBruto/procentagem);
        return $"\nDados Atualizados:\nNome: {Nome}\nSalário: R${salarioAtualizado:F2}\n";
    }
}