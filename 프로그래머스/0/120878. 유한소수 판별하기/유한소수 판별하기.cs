using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int a, int b) {
        int gcd = GCD(a,b);
        return PrimDivision((b/gcd)).Where(x=> x!=2&&x!=5).ToArray().Length > 0? 2:1;
    }
    private int GCD(int a, int b)
    {
        if(b == 0) return a;
        int c = a%b;
        return GCD(b,c);
    }
    
    private List<int> PrimDivision(int num)
    {
        List<int> results = new List<int>();
        for(int i = 2; 1 < num; i++)
        {
            if(num%i == 0)
            {
                results.Add(i);
                num /= i;
                i = 1;
            }
        }
        return results;
    }
}