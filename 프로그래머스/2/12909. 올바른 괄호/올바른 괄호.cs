using System;

public class Solution {
    public bool solution(string s) {
        int count = 0;
        for(int i = 0; i< s.Length; i++)
        {
            if(s[i] == '(')count++;
            else count--;
            if(count < 0) return false;
        }
        return count != 0 ? false : true;
    }
}