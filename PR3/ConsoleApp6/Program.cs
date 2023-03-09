

Random rand = new Random();
rand.GetIntFixedLength(8);

public static class RandExtension
{
    public static int GetIntFixedLength(this Random rand, int length)
    {
        length = length > 0 && length < 10 ? length : 1; 
        return rand.Next(Convert.ToInt32(Math.Pow(10, length - 1)),
                         Convert.ToInt32(Math.Pow(10, length)));

        


    }

    static void Calc()//дисперсия
    {

        int N = 0;
        double sum;
        int myN;
        int i, j, k;
        double[] avr;
        avr = new double[N];

        for (i = 1; i <= N / 2; i++)
        {
            myN = N / i;
            for (j = 0; j <= myN - 1; j++)
            {
                sum = 0;
                for (k = j * i; k < j * i + i; k++)
                {
                    sum += k;
                }
                avr[j] = sum / i;
            }
            sum = 0;
            for (j = 0; j < (myN - 1); j++)
            {
                sum += Math.Pow((avr[j + 1] - avr[j]), 2);
            }
            
        }

    }
    public static double StandardDeviation(List<double> valueList)//среднеквадратическое отклонение
    {
        double M = 0.0;
        double S = 0.0;
        int k = 1;
        foreach (double value in valueList)
        {
            double tmpM = M;
            M += (value - tmpM) / k;
            S += (value - tmpM) * (value - M);
            k++;
        }
        return Math.Sqrt(S / (k - 2));
    }
    
}

