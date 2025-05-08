using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] array) {
        
        return new int[2]{array.Max(),Array.IndexOf(array,array.Max())};
    }
}