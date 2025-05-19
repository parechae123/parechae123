using System;
using System.Linq;

//정수 n과 가까운 순서로 정렬
//n과 가까운 순서대로 정렬하되 a,b의 dist가 같을 시 둘 중 더 큰값을 앞으로 데려옴
public class Solution {
    public int[] solution(int[] numlist, int n) {
        return numlist.OrderBy(x => Math.Abs(x-n)).ThenByDescending(x=>x).ToArray();
    }
}