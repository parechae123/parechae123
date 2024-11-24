using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] numbers) {
        List<int> numberList = new List<int>(numbers);
        Queue<int> nContains = new Queue<int>();
        for(int i = 1; i<10; i++)
        {
            if(numberList.Contains(i)) continue;
            else nContains.Enqueue(i);
        }
        int answer = 0;
        while(nContains.Count > 0)
        {
            answer+= nContains.Dequeue();
        }
        
        return answer;
    }
}