using System;

namespace DeadEnd_Cs;

public class Functions{
    public static Tuple<int, long> DeadEnd(long n){
        int seriesLength = 0;
        long lastTerm = 0;
        Queue<long> currentTriplet = new Queue<long>();

        //initial population of the queue
        //1st term
        Console.WriteLine(n);//
        seriesLength = 1;
        if(n.Equals(1)){
            lastTerm = 1;
        }else{
            long digitSum;
            long nextTerm;
            currentTriplet.Enqueue(n);
            //2nd term
            digitSum = DigitSum(n);
            //Console.WriteLine($"Long Digit Sum: {digitSum}");//
            //Console.WriteLine($"{n} mod {digitSum} = {n%digitSum}");//
            nextTerm = (n % digitSum).Equals(0) ? n/digitSum : n*digitSum;
            Console.WriteLine(nextTerm);//
            seriesLength++;
            if(nextTerm.Equals(1)){
                lastTerm = 1;
            }else{
                currentTriplet.Enqueue(nextTerm);
                //ith term, i > 2
                bool seriesContinues = true;
                while(seriesContinues){
                    digitSum = DigitSum(nextTerm);
                    nextTerm = (nextTerm % digitSum).Equals(0) ? nextTerm/digitSum : nextTerm*digitSum;
                    Console.WriteLine(nextTerm);
                    if(nextTerm.Equals(1)){
                        seriesLength++;
                        lastTerm = 1;
                        seriesContinues = false;
                    }else if(nextTerm.Equals(currentTriplet.Dequeue())){
                        lastTerm = currentTriplet.Dequeue();
                        seriesContinues = false;
                    }else{
                        currentTriplet.Enqueue(nextTerm);
                        seriesLength++;
                    }
                }
            }
        }

        return new Tuple<int, long>(seriesLength, lastTerm);
    }

    public static int DigitSum(long posInt){

        long net = posInt;
        long divisor = 10;
        int sum = 0;
        for(; net > 0; net=(net/divisor)*divisor, divisor*=10){   
            //Console.WriteLine($"{net} mod {divisor} = {net%divisor}");//        
            sum += Convert.ToInt32((net % divisor) / (divisor/ 10));
            /*
            Console.WriteLine($"divisor = {divisor}");
            Console.WriteLine($"quotient = {net}");
            Console.WriteLine($"digit = {(net % divisor) / (divisor/10)}");
            Console.WriteLine($"sum = {sum}");
            */
        }
        //Console.WriteLine($"Digital Sum of {posInt} = {sum}");//
        return sum;
    }
}