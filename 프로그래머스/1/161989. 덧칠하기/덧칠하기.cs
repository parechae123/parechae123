using System;


public class Solution {
    public int solution(int n, int m, int[] section) 
    {
        int answer = 0;
        int currStartSection = section[0];
        
        for(int i = 1; i< section.Length;i++)
        {
            if(section[i]-currStartSection < m)
            {
                continue;
            }
            else
            {
                answer++;
                currStartSection = section[i];
            }
        }
        answer++;
        return answer;
    }
}