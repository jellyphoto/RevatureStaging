using System;

namespace DeadEnd_Cs;

public class Program{
    public static void Main(string[] args){
        int n = 0;

        Console.WriteLine("Enter a positive integer");
        try{
            n = Convert.ToInt32(Console.ReadLine());
        }catch(Exception e){
            Console.WriteLine(e.Message);
        }

        Console.WriteLine(Functions.DigitSum(n));
        
    }
}
