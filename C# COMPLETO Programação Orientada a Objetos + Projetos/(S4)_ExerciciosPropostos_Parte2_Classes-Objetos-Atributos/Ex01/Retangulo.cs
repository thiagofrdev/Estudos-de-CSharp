class Retangulo{
    public double Largura;
    public double Altura;

    public double AeraRetangulo(){
        return Math.Round(Altura*Largura, 2);
    }

    public double PerimetroRetangulo(){
        return Math.Round(2*(Altura+Largura), 2);
    }

    public double DiagonalRetangulo(){
        return Math.Round(Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2)), 2);
    }

    public override string ToString(){
        return $"ÁREA = {AeraRetangulo():F2}\nPERÍMETRO = {PerimetroRetangulo():F2}\nDIAGONAL = {DiagonalRetangulo():F2}";
    }
}