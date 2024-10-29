//Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais velha.
Pessoa pA, pB;

pA = new Pessoa();
pB = new Pessoa();

Console.WriteLine("Dados da primeira pessoa:");
Console.Write("Nome: ");
pA.nome = Console.ReadLine();
Console.Write("Idade: ");
pA.idade = int.Parse(Console.ReadLine());

Console.WriteLine("Dados da segunda pessoa:");
Console.Write("Nome: ");
pB.nome = Console.ReadLine();
Console.Write("Idade: ");
pB.idade = int.Parse(Console.ReadLine());

Console.Write(pessoaMaisVelha());

string pessoaMaisVelha(){
    if(pA.idade > pB.idade){
        return $"Pessoa mais velha: {pA.nome}";
    } else if (pA.idade == pB.idade){
        return $"Ambos tem a mesma idade";
    } else {
        return $"Pessoa mais velha: {pB.nome}";
    }
}