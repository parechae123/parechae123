using System;
using System.Collections.Generic;
public class Solution {
    public double[] solution(int k, int[,] ranges) {
        List<double> ubak = new List<double>();
        ubak.Add(k);
        while(k > 1)
        {
            if(k%2 == 1) k = (k*3)+1;
            else k /= 2;
            ubak.Add(k);
        }

        for(int i = 0; i<ubak.Count-1; i++)
        {
            ubak[i] = (ubak[i] +ubak[i+1])/2d;
        }
        ubak.RemoveAt(ubak.Count-1);
        double[] answer = new double[ranges.GetLength(0)];
        for(int i = 0; i<ranges.GetLength(0); i++)
        {
            int start = ranges[i,0];
            //0이 나오는 경우에 그대로 넣어 줄 시 outOfRange 발생하니 -1해줌
            int end = (ubak.Count+ranges[i,1]);
            if(start > end)
            {
                Console.WriteLine($"{ubak.Count} {start} {end}");
                answer[i] = -1; 
                continue;
            }
            else if( start == end){answer[i] = 0; continue;}
            end -=1;
            for(;start<=end; start++)
            {
                answer[i] += ubak[start];
            }
        }

        
        return answer;
    }
}