Console.Write("Quantidade de hospedes: ");
int quantidade = int.Parse(Console.ReadLine());

Hospede[] quartos = new Hospede[10];

for(int i = 0; i < quantidade; i++) {
    Console.Write($"\nHospede {i+1}\nNome: ");
    string nome = Console.ReadLine();
    Console.Write("Email: ");
    string email = Console.ReadLine();
    Console.Write("Quarto (1 - 10): ");
    int numeroQuarto = int.Parse(Console.ReadLine());

    quartos[numeroQuarto-1] = new Hospede(nome, email, numeroQuarto);
}

Console.WriteLine("\nBusy Rooms:");
for (int i = 0; i < quartos.Length; i++){    
    if (quartos[i] != null){
        Console.WriteLine(quartos[i].ToString());
    }
}