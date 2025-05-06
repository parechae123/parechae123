using System;
using System.Linq;

public class Solution {
    public string solution(string myString) {
        return new string(myString.Select(x=>x >='a'? (char)(x-('a'-'A')) : (char)x).ToArray());
    }
}