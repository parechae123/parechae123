using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] picture, int k) {
        List<StringBuilder> answer = new List<StringBuilder>();
        for(int i = 0; i< picture.Length; i++)
        {
            StringBuilder currSb = new StringBuilder();
            
            for(int j = 0; j< picture[i].Length; j++)
            {
                for(int m = 0; m< k; m++)
                {
                    currSb.Append(picture[i][j]);
                }
            }
            
            for(int l = 0; l< k; l++)
            {
                answer.Add(currSb);
            }
        }
        return answer.Select(x=>x.ToString()).ToArray();
    }
}