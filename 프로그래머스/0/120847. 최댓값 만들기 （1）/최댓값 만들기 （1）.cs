using System;
using System.Linq;
public class Solution {
    public int solution(int[] numbers) {
        Array.Sort(numbers,(num1,num2)=> num2.CompareTo(num1));
        return numbers[0]*numbers[1];
    }
}