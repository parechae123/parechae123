using System;
using System.Linq;
//0~n의 정수
public class Solution {
    public int[] solution(int[] num_list, int n) {
        return num_list.Take(n).ToArray();
    }
}