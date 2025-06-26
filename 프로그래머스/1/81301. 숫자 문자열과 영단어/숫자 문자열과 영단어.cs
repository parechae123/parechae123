using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(string s) {
        Dictionary<string,char> dict = new Dictionary<string,char>{{"zero" , '0'},{"one", '1'}, {"two",'2'},{"three",'3'}
                                                                 ,{"four",'4'}, {"five",'5'},{"six",'6'},
                                                                 {"seven",'7'}, {"eight",'8'},{"nine",'9'}};
        int cur = 0;
        StringBuilder answer = new StringBuilder();
        for(int i =0; i < s.Length; i++)
        {
            string numText = new string(s.Skip(cur).Take(i-cur+1).ToArray());
            if((s[i] >= '0' && s[i] <= '9'))
            {
                cur = i+1;
                answer.Append(s[i]);
                continue;
            }
            else if(dict.ContainsKey(numText))
            {
                cur = i+1;
                answer.Append(dict[numText]);
                continue;
            }
        }
        return int.Parse(answer.ToString());
    }
}