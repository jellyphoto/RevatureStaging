using System;

namespace AlmostPalindrome.PalindromeAlgs;

public class PalindromeAnalyzer
{
    public PalindromeAnalyzer(){
        Console.WriteLine("new PalindromeAnalyzer instance");
    }

    //methods
    public bool AlmostPalindrome(string word){
        if(word.Equals("")){
            return false;
        }

        int nonMatchPairCount = 0;
        int i = 0;
        int j = word.Length - 1;

        while(i < j){
            if(!word[i].Equals(word[j])){
                nonMatchPairCount += 1;
                if(nonMatchPairCount > 1){
                    return false;
                }
            }
            i++;
            j--;
        }
        return true;
    }
}