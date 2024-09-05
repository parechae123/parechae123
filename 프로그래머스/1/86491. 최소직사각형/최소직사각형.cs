using System;

public class Solution {
    public int solution(int[,] sizes) {
        int vertMax = 0;
        int horizMax = 0;
        for(int i = 0;i< sizes.GetLength(0);i++)
        {
            if(sizes[i,0] > sizes[i,1])
            {
                if(sizes[i,0] > vertMax)
                {
                    vertMax = sizes[i,0];
                }
                if(sizes[i,1] > horizMax)
                {
                    horizMax = sizes[i,1];
                }
            }
            else
            {
                if(sizes[i,1] > vertMax)
                {
                    vertMax = sizes[i,1];
                }
                if(sizes[i,0] > horizMax)
                {
                    horizMax = sizes[i,0];
                }
            }
        }
        Console.WriteLine(vertMax);
        Console.WriteLine(horizMax);
        return vertMax *horizMax;
    }
}