using System;
using StaircaseOfRecursion.functions;

public class Program{
    public static void Main(string[] args){
        Console.WriteLine("Enter the number of stairs");
        int n = 0;
        try{
            n = Convert.ToInt32(Console.ReadLine());
        }catch(Exception e){
            Console.WriteLine(e.Message);
        }
        Console.WriteLine(Steps.waysToClimb(n));
        Console.ReadKey();
        
        /*
        for(n=0; n < 100; n++){
            Console.WriteLine(Steps.waysToClimb(n));
        }
        */
    }
}
