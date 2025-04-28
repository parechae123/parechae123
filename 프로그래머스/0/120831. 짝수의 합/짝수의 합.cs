using System;
using System.Linq;
public class Solution {
    public int solution(int n) {
        return Enumerable.Range(0,n+1).Where(x=>x%2 == 0).ToArray().Sum();
    }
}