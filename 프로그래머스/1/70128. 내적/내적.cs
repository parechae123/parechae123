using System;
using System.Linq;

public class Solution {
    public int solution(int[] a, int[] b) {
        return a.Zip(b,(item1,item2)=> item1*item2).Sum();
    }
}