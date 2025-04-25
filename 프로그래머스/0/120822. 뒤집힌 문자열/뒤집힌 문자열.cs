using System;
using System.Linq;

public class Solution {
    public string solution(string my_string) {
        char[] answer = my_string.ToArray();
        Array.Reverse(answer);
        return new string(answer);
    }
}