using System;

public class Solution {
    public int solution(string myString, string pat) {
        return myString.Contains(pat,StringComparison.CurrentCultureIgnoreCase)? 1 : 0;
    }
}