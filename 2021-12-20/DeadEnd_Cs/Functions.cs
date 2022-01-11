using System;

namespace DeadEnd_Cs;

public class Functions{
    public static Tuple<int, int> DeadEnd(int n){
        int seriesLength = 0;
        int lastTerm = 0;
        //s = the sum of the digits in n
        int s = DigitSum(n);
        
        
        return new Tuple<int, int>(seriesLength, lastTerm);
    }

    public static int DigitSum(int posInt){
        int divisor = 10;
        int quotient = posInt;
        int sum = 0;
        for(; quotient > 0; quotient=quotient/divisor, divisor*=10){
            sum += (quotient % divisor) / (divisor/10);
        }
        return sum;
    }
}