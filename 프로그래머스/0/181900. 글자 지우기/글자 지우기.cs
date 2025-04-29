using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string solution(string my_string, int[] indices) {
        string answer = new string(my_string.ToCharArray().Where((x,idx) => !indices.Contains(idx)).ToArray());
        
        return answer;
    }
}