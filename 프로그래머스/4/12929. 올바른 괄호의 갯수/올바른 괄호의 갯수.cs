using System;
public class Solution {
    public int solution(int n) {
        int answer = 0;
        int[] dp = new int[n+1];
        
        
        if(n <= 1) return 1;
        dp[0] = dp[1] = 1;
        //0과 1은 이미 구했으니까 2부터 시작
        for(int i = 2; i<= n; i++)
        {
            dp[i] = 0;//값초기화

            for(int j = 0; j<i; j++)
            {
                dp[i] += dp[j]*dp[i-1-j];
                //i번째 배열 미만의 숫자
                //i미만 부터 0까지의 숫자(i-1 이후 j를 뺀 값)
            }
            Console.WriteLine(i+"번째 DP");
        }
        return dp[n];
    }
}