using System;
using System.Linq;

public class Solution {
    public int solution(int[] num_list) {
        return Array.FindIndex(num_list,x => x<0);
    }
}