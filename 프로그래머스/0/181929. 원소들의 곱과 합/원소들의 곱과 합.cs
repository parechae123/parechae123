using System;
using System.Linq;
public class Solution {
    public int solution(int[] n) {
        return n.Aggregate((x,y)=>x*y) < (n.Sum()*n.Sum())? 1: 0;
    }
}