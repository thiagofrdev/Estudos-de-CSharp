class Hospede{
    public string? Nome { get; set; }
    public string? Email { get; set; }
    public int NumeroQuarto { get; set; }

    public Hospede(string nome, string email, int numeroQuarto) {
        Nome = nome;
        Email = email;
        NumeroQuarto = numeroQuarto;
    }

    public string ToString(){
        return $"({NumeroQuarto}): "
        + $"Nome: {Nome}, "
        + $"{Email}";
    }

}