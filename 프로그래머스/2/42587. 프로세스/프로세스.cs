using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] priorities, int location) {
        int answer = 0;
        Queue<int> procQueue = new Queue<int>(priorities);
        Array.Sort(priorities,(item1,item2) => item2.CompareTo(item1));
        Queue<int> maxQueue = new Queue<int>(priorities);
        while(maxQueue.Count > 0)
        {
            location--;
            if(maxQueue.Peek() == procQueue.Peek())
            {
                maxQueue.Dequeue();
                procQueue.Dequeue();
                answer++;
                if(location == -1)break;
            }
            else
            {
                if(location == -1) location = procQueue.Count-1;
                procQueue.Enqueue(procQueue.Dequeue());

            }
        }
        return answer;
    }
}