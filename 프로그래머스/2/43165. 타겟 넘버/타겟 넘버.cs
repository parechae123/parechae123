using System;

public class Solution {
    public int solution(int[] numbers, int target) 
    {
        return DFS(numbers,0,target,0);
    }
    public int DFS(int[] numbers,int depth, int target,int currValue)
    {
        int count = 0;
        if(depth == numbers.Length)
        {
            if(target == currValue)
            {
                count++;
                
            }
            return count;
        }
        int plusValue = currValue + numbers[depth];
        int minusValue = currValue - numbers[depth];
        
        
        count += DFS(numbers,depth+1, target, plusValue);
        count += DFS(numbers,depth+1, target, minusValue);
        return count;
    }
    
}