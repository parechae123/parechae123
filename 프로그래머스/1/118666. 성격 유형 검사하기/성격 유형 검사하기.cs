using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;


public class Solution {
    public string solution(string[] survey, int[] choices) {
        Dictionary<char,int> dict = new Dictionary<char,int>();
        char[] c = new char[8]{'R','T','C','F','J','M','A','N'};
        for(int i = 0; i< c.Length; i++)
        {
            dict.Add(c[i],0);
        }
        
        for(int i = 0; i < choices.Length; i++)
        {
            int result = Math.Abs(choices[i]-4);
            if(choices[i] <4)
                dict[survey[i][0]] += result;
            else 
                dict[survey[i][1]]+=result;
        }
        
        StringBuilder sb = new StringBuilder();
        for(int i = 0; i< c.Length; i+=2)
        {
            sb.Append(dict[c[i]] >= dict[c[i+1]] ? c[i] : c[i+1]);
        }
        
        return sb.ToString();
    }
}