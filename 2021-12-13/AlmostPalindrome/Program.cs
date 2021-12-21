using System;
using AlmostPalindrome.PalindromeAlgs;

class Program{
    static void Main(string[] args){
        string word = "";
        bool isAlmostPalindrome = false;
        Console.WriteLine("Please enter a word to analyze");
        word = Console.ReadLine();

        PalindromeAnalyzer analyzer = new PalindromeAnalyzer();

        try{
            isAlmostPalindrome = analyzer.AlmostPalindrome(word);
        }catch(Exception e){
            Console.WriteLine(e.Message);
            word = string.Empty;
        }finally{
            if(isAlmostPalindrome){
                Console.WriteLine($"the word: '{word}' is an Almost Palindrome");
            }else{
                Console.WriteLine($"the word: '{word}' is not an Almost Palindrome");
            }
        }
    }
}
