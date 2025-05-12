using System;
using System.Linq;

public class Solution {
    public string[] solution(string my_str, int n) {
        return Enumerable.Repeat("",(my_str.Length/n)+(my_str.Length%n ==0?0: 1)).
            Select((str,idx)=>new string(my_str.Skip(idx*n).Take(n).ToArray())).ToArray();
    }
}