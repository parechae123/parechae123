using System;

class Solution 
{
    public int solution(int n) 
    {
        int answer = n;
        int nBits = BitCount(n);
        while(true)
        {
            answer += 1;
            //Console.WriteLine(answer);
            if(nBits == BitCount(answer))break;
        }
        //Console.WriteLine(BitCount(n));
        return answer;
    }
    public int BitCount(int n)
    {
        int result =0;
        while(n >0)
        {
            if((n&1)== 1)
            {
                result++;
            }
            n >>= 1;
        }
        return result;
    }
}