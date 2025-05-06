using System;
using System.Text.RegularExpressions;

public class Solution {
    public string solution(string my_string) {
        return Regex.Replace(my_string,"[a,e,i,o,u]","");
    }
}