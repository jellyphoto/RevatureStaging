using System;

namespace StaircaseOfRecursion.functions;

public class Steps{
    public static int waysToClimb(int n){
        if(n.Equals(0) || n.Equals(1)){
            return 1;
        }
        return waysToClimb(n-1) + waysToClimb(n-2);
    }
}