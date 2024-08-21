using System;

class Solution
{
    public int[] solution(int n, string[] words)
    {
        int[] answer = {0,0};
        int defeatWordArray = 0;
        for(int i = 0; i<words.Length; i++)
        {
            for(int j = 0; j<words.Length; j++)
            {
                if(i == j ||j< i)
                {
                    continue;
                }
                else
                {
                    if(answer[1] < ((j)/n)+1&&answer[1] != 0)break;
                    else
                    {
                        if(answer[1] == ((j)/n)+1&&answer[1] != 0)
                        {
                            if(answer[0] < ((j)%n)+1&&answer[1] != 0)break;
                        }
                    }
                    
                    
                    if(words[i] == words[j])
                    {
                        //중복된 단어 처리
                        answer[0] = (j%n)+1;
                        answer[1] = (j/n)+1;
                        break;
                    }
                }
            }
                
            if(i+1 < words.Length)
            {
                if(words[i][words[i].Length-1] !=words[i+1][0])
                {
                    //그 다음턴에 죽는사람이니까 i+1을 해줘야함
                    if(answer[1] < ((i+1)/n)+1&&answer[1] != 0)break;
                    else
                    {
                        if(answer[1] == ((i+1)/n)+1&&answer[1] != 0)
                        {
                            if(answer[0] < ((i+1)%n)+1&&answer[1] != 0)break;
                        }
                    }
                    answer[0] = ((i+1)%n)+1;
                    answer[1] = ((i+1)/n)+1;
                    break;
                }
            }
            

        }
        
        //단어 순서%n = 플레이어, 단어순서 /n = 플레이어 턴
        Console.WriteLine("플레이어"+answer[0]+"순서"+answer[1]);
        return answer;
    }
}