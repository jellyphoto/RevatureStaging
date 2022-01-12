using System;

namespace DeadEnd_Cs;

public class Program{
    public static void Main(string[] args){
        long n = 0;

        Console.WriteLine("Enter a positive integer");
        try{
            n = Convert.ToInt32(Console.ReadLine());
        }catch(Exception e){
            Console.WriteLine(e.Message);
        }

        Console.WriteLine($"Digit Sum: {Functions.DigitSum(n)}");

        Tuple<int, long> result = Functions.DeadEnd(n);
        Console.WriteLine($"Series Length: {result.Item1}");
        Console.WriteLine($"Last Term: {result.Item2}");

        Console.ReadKey();
    }
}
