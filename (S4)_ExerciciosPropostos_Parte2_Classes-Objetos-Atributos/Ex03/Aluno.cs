using System.Globalization;

class Aluno{
    public string Nome;
    public double[] Notas = new double[3];

    public double Somatorio(){
        return Notas[0]+Notas[1]+Notas[2];
    }

    public string Situacao(){
        if(Somatorio() >= 60){
            return "APROVADO";
        } else {
            return $"REPROVADO\nFALTARAM {60 - Somatorio():F1} PONTOS";
        }
    }
    public string ToStringResultado(){
        return $"NOTA FINAL = {Somatorio():F1}\n{Situacao()}";
    }
}