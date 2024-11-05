List<Funcionario> lista = new List<Funcionario>();

Console.Write("Quantidade: ");
int quantidade = int.Parse(Console.ReadLine());

for (int i = 0; i < quantidade; i++){
    Console.WriteLine($"\nFuncionario {i+1}");
    Console.Write("ID: ");
    int id = int.Parse(Console.ReadLine());
    foreach (var f in lista){
        if (f.Id == id){
            Console.WriteLine("Esse ID já está cadastrado!");
        }
    }
    Console.Write("Nome: ");
    string nome = Console.ReadLine();
    Console.Write("Salário: ");
    double salario = double.Parse(Console.ReadLine());

    Funcionario funcionario = new Funcionario(id, nome, salario);
    lista.Add(funcionario);
}

Console.Write("\nID do usuario para aumentar salario: ");
int idAumentarSalario = int.Parse(Console.ReadLine());
foreach (Funcionario funcionario in lista){
    if (funcionario.Id == idAumentarSalario){
        Console.Write("Porcentagem: ");
        funcionario.aumentarSalario(double.Parse(Console.ReadLine()));
        break;
    } else {
        Console.WriteLine("Esse usuario não existe!");
    }
}

Console.WriteLine("");
foreach (Funcionario funcionario in lista){
    Console.WriteLine(funcionario.ToString());
}