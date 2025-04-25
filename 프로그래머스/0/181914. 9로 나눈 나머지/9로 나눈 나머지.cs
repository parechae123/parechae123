using System;
using System.Linq;

public class Solution {
    //48~57
    public int solution(string number) {
        return (number.Select(x =>x - '0').ToArray().Sum())%9;
    }
}