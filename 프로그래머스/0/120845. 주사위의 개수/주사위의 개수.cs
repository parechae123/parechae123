using System;
using System.Linq;
public class Solution {
    //int 배열 box 안에는 상자의 가로 세로 높이의 길이순
    //정육면체 주사위의 크기 == n
    public int solution(int[] box, int n) {
        box = box.Select(x=> (x-(x%n))/n).ToArray();
        return box.Aggregate((f,b) => f*b);
    }
}