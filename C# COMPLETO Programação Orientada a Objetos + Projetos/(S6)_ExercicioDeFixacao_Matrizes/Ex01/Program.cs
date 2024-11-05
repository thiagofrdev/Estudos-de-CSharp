Console.Write("Linhas: ");
int linhas = int.Parse(Console.ReadLine());
Console.Write("Colunas: ");
int colunas = int.Parse(Console.ReadLine());

double[,] matriz = new double[linhas, colunas];

Console.WriteLine("Entreva os números dessa forma -> (x, y, z)");
for (int i = 0; i < linhas; i++){
    Console.Write($"Valores da {i+1}ª linha: ");
    string entrada = Console.ReadLine();
    string[] valores = entrada.Split(", ");
    for (int j = 0; j < valores.Length && j < colunas; j++){
        if (double.TryParse(valores[j], out double valor)){
            matriz[i, j] = valor;
        } else {
            Console.WriteLine($"Valor '{valores[j]}' inválido. Ignorando.");
        }
    }
}

Console.WriteLine("\nDiagonal Principal: ");
for(int i = 0; i < linhas; i++){
    for(int j = 0; j < colunas; j++){
        if (i==j){
            Console.WriteLine($"[{i}][{j}] = {matriz[i,j]} ");   
        }
    }
}

int quantidadeNegativos = 0;
for(int i = 0; i < linhas; i++){
    for(int j = 0; j < colunas; j++){
        if (matriz[i, j] < 0){
            quantidadeNegativos++;   
        }
    }
}
Console.Write("\nNegativos: " + quantidadeNegativos);