using System;
using System.Linq;

public class Solution {
    public int[] solution(int start_num, int end_num) {
        return Enumerable.Range(start_num,(end_num+1)-start_num).ToArray();
    }
}