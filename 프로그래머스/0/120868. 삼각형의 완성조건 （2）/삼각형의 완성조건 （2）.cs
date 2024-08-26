using System;
using System.Collections.Generic;

public class Solution {
    //가장 긴 변의 길이< a+b
    //
    //6 < 3+n
    //주어진 변의 길이 중 하나가 가장 긴 길이인 경우 = a < b+n
    //b+n> a && n < a+b
    public int solution(int[] sides) {
        int answer = 0;
        Array.Sort(sides,(int item1,int item2) =>(item2.CompareTo(item1)));
        //주어진 숫자의 크기순으로 정렬
        //sides[0]가 가장 큰 값일때 sides[0] < sides[1]+i
        for(int i = 0; i < sides[1]+sides[0] ; i++)
        {
            if(sides[0] < sides[1]+i)
            {
                answer++;
            }

        }
        
        
        return answer;
    }
    
}