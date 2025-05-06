using System;

public class Solution {
    public long solution(int balls, int share) {
        return DFS(balls,share);
    }
    public long DFS(int d, int n)
    {
        if(n == 0)return 1;
        long result = DFS(d-1,n-1);
        result *= d;
        result /= n;
        
        return result;
    }
}