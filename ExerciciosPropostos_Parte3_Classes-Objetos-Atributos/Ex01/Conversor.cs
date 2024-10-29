class Conversor{
    public static double Iof = 6.0;

    public static double RealToDolar(double precoDolar, double dolares){
        double multi = precoDolar*dolares;
        return multi + multi*Iof/100;
    }
}