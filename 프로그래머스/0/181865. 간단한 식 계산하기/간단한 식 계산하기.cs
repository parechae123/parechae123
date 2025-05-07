using System;
using System.Linq;

public class Solution {
    public int solution(string binomial) {
        string[] numbers = binomial.Split(' ');
        return numbers[1] == "*"? int.Parse(numbers[0])*int.Parse(numbers[2]) : 
        numbers[1] == "-"? int.Parse(numbers[0])-int.Parse(numbers[2]) :
        int.Parse(numbers[0])+int.Parse(numbers[2]);
    }
}