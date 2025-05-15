using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int a, int b) {
        b /= GCD(a,b);
        return GetPrimDivid(b).Count(x=> x != 2 &&x != 5) >0? 2 : 1;
    }
    public int GCD(int a,int b)
    {
        if(b== 0) return a;
        int c = a%b;
        return GCD(b,c);
    }
    public List<int> GetPrimDivid(int a)
    {
        List<int> results = new List<int>();
        for(int i = 2; 1 < a ;i++)
        {
            if(a%i == 0)
            {
                a /= i;
                results.Add(i);
                i = 1;
            }
        }
        return results;
    }
}