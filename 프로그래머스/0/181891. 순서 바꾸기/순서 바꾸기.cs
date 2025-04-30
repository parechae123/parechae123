using System;
using System.Linq;
public class Solution {
    public int[] solution(int[] num_list, int n) {
        return num_list.Skip(n).Take(num_list.Length-n).Concat(num_list.Take(n)).ToArray();
    }
}