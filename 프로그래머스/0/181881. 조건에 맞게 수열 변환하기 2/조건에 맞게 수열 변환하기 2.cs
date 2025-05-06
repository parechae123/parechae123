using System;
using System.Linq;

public class Solution {
    public int solution(int[] arr) {
        return DFS(arr,1);
    }
    public int DFS(int[] arr,int curNum)
    {
        int[] curArr = arr.Select(x=> x >= 50? x%2 == 0? x/2: x :x%2 == 1? x*2+1: x).ToArray();
        if(curArr.SequenceEqual(arr)) return curNum-1;
        int result = DFS(curArr,curNum+1);
        return result;
    }
}