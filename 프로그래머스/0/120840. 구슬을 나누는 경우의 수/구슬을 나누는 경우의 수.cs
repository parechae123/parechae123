using System;

public class Solution {
    public double solution(int balls, int share) {
        return Comb(balls,share);
    }
    public double Comb(int n, int r)
    {
        if(r > n-r)r = n-r;
        double result = 1;
        for(int i = 1; i <= r; i++)
        {
            result *= n-i+1;
            result /= i;
            
        }
        return result;
    }
}