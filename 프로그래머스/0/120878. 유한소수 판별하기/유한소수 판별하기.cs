using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(int a, int b) {
        return PrimeDivi(b/GCD(a,b)).Count(x => x!=2 && x!= 5) > 0? 2 : 1;
    }
    public int GCD(int a,int b)
    {
        if(b == 0)return a;
        int c = a%b;
        
        return GCD(b,c);
    }
    public List<int> PrimeDivi(int num)
    {
        List<int> result = new List<int>();
        for(int i = 2; 1 < num; i++)
        {
            if(num% i == 0)
            {
                num /= i;
                result.Add(i);
                i = 1;
            }
        }
        return result;
    }
}