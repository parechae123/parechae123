using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] ingredient) {
        List<int> ingList = new List<int>();
        int answer = 0;
        foreach(int item in ingredient)
        {
            ingList.Add(item);
            if(ingList.Count<=3) continue;
            if(ingList[ingList.Count-4] ==1 &&ingList[ingList.Count-3] ==2
              &&ingList[ingList.Count-2] ==3&&ingList[ingList.Count-1] ==1)
            {
                answer++;
                ingList.RemoveRange(ingList.Count-4,4);
            }
        }
        return answer;
    }
}