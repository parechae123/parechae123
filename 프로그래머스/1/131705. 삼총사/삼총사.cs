using System;

public class Solution {
    
    //삼총사가 될 수 있는 경우의 수
    public int solution(int[] number) {
        int answer = 0;
        for(int i = 0; i< number.Length; i++)
        {
            for(int j = i+1; j< number.Length; j++)
            {
                for(int k = j+1; k< number.Length; k++)
                {
                    if((number[i]+number[j]+number[k])==0)
                    {
                        answer++;
                    }
                }
            }
        }
        return answer;
    }
}