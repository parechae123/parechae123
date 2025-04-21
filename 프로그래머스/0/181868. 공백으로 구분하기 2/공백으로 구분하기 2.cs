using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string my_string) {
        List<string> answer = new List<string>();
        int index = 0;
        answer.Add(String.Empty);
        foreach(char result in my_string)
        {

            if(result != ' ')
            {
                answer[index] += result;
            }
            else
            {
                if(answer[index] ==String.Empty)continue;
                answer.Add(String.Empty);
                index++;
                continue;
            }
        }
        if(answer[index]== String.Empty)answer.RemoveAt(index);
        return answer.ToArray();
    }
}