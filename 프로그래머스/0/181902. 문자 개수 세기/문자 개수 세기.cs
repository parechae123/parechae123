using System;
using System.Linq;
using System.Collections.Generic;
public class Solution {
    public int[] solution(string my_string) {
        List<int> answer = new List<int>();
        char[] charString = my_string.ToCharArray();
        for(int i = 'A'; i<= 'z'; i++)
        {
            answer.Add(charString.Where(x => x==(char)i).Count());
            if(i == 'Z')
            {
                i= 'a'-1;
            }
        }
        return answer.ToArray();
    }
}