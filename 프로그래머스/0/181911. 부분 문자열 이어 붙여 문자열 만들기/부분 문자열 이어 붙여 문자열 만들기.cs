using System;
using System.Linq;
public class Solution {
    public string solution(string[] my_strings, int[,] parts) {
        string answer = string.Empty;
        
        for(int i = 0; i< my_strings.Length; i++)
        {
            char[] tempArr = my_strings[i].ToCharArray();
            answer += new string(tempArr.Skip(parts[i,0]).Take(parts[i,1]-parts[i,0]+1).ToArray());
        }
        
        return answer;
    }
}