using System;
using System.Collections.Generic;
public class Solution {
    //stack 자료형 쓰면 될듯
    //n개를 w개 만큼 가로로 배열해서 위로 쌓을 때
    //num에 해당하는 박스를 몇개 꺼내야 하는지
    public int solution(int n, int w, int num) {
        
        Stack<int>[] boxes = new Stack<int>[w];
        int sortedBoxCount = 1;
        int targetIndex = -1;
        while(sortedBoxCount <= n)
        {
            for(int i = 0; (i < w); i++)
            {
                if(n < sortedBoxCount) break;
                
                if(boxes[i]== null) boxes[i] = new Stack<int>();
                boxes[i].Push(sortedBoxCount);
                if(num == sortedBoxCount)targetIndex = i;
                sortedBoxCount++;
            
            }
            for(int i = w-1; (i >= 0); i--)
            {
                if(n < sortedBoxCount) break;
                boxes[i].Push(sortedBoxCount);
                if(num == sortedBoxCount)targetIndex = i;
                sortedBoxCount++;
            }
        }
        int answer = ToGetCount(num,boxes[targetIndex]);
        return answer;
    }
    
    public int ToGetCount(int num, Stack<int> line)
    {
        int result = 0;
        while(line.Count> 0)
        {
            result++;
            if(num == line.Pop())
            {
                return result;
            }
        }
        return -1;
    }
}