using System;

public class Solution {
    public int solution(int number, int limit, int power) {
        int answer = 0;
        for(int i = 1; i<= number; i++)
        {
            int temp = GetmeasureNum(i);
            if(temp>limit)
            {
                answer += power;
            }
            else
            {
                answer += temp;
            }
        }
        
        return answer;
    }
    public int GetmeasureNum(int num)
    {


        int temp =0;
        for(int i = 1; i<=num/2;i++)
        {
            if(num%i ==0)
            {
                temp++;
            }
        }
        temp++;
        return temp;
    }
}