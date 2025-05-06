using System;
using System.Linq;

public class Solution {
    public string solution(string myString) {
        return new string (myString.Select(x=> x == 'a'|| x== 'A' ? 'A':
                                         (x < 'a')&&x != ' '? (char)(x+('a'-'A')) : x).ToArray());
    }
}