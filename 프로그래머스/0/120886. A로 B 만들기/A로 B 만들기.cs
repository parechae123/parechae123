using System;
using System.Linq;

public class Solution {
    public int solution(string before, string after) {
        var aGroup = after.OrderBy(x=>x).GroupBy(x=>x).Select(x=>(x.Key,x.Count())).ToArray();
        var bGroup = before.OrderBy(x=>x).GroupBy(x=>x).Select(x=>(x.Key,x.Count())).ToArray();
        return aGroup.SequenceEqual(bGroup)? 1 : 0;
    }
}