using System;

public class Solution {
    public long solution(int balls, int share) 
    {
        return dfs(balls,share);
    }
    public long dfs(int n,int m)
    {
        if(m == 0)return 1;
        long result = dfs(n-1,m-1);
        result *= n;
        result /= m;
        return result;
    }
}