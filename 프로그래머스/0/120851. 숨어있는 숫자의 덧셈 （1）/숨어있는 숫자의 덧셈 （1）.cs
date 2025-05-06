using System;
using System.Linq;

public class Solution {
    public int solution(string my_string) {
        return my_string.Where(x=> x>='1'&& x<='9').Select(x=>x-'0').ToArray().Sum();
    }
}