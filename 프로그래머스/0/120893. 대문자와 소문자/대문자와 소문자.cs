using System;
using System.Linq;

public class Solution {
    public string solution(string my_string) {
        return new string(my_string.Select(x=> x>='a'? (char)(x-('a'-'A')) : (char)(x+('a'-'A'))).ToArray());
    }
}