using System;

//드래그 시작점 위치 = X = answer[0],Y = answer[1]
//끝점 위치 = answer[2],answer[3]
//#의 위치는 파일이 있는 위치
public class Solution {
    public int[] solution(string[] wallpaper) {
        int[] answer = new int[] {int.MaxValue,int.MaxValue,int.MinValue,int.MinValue};
        for(int i = 0; i< wallpaper.Length; i++)
        {
            for(int j = 0; j< wallpaper[i].Length; j++)
            {
                if(wallpaper[i][j] == '#')
                {
                    answer[0] = answer[0]> i? i : answer[0]; 
                    answer[1] = answer[1]> j? j : answer[1]; 
                    
                    //파일이 있는 점이 포함되엉 ㅑ하기 때문에 최댓값의 좌표 +1을 해줌
                    answer[2] = answer[2]< i+1? i+1 : answer[2]; 
                    answer[3] = answer[3]< j+1? j+1 : answer[3]; 
                }
            }
        }
        return answer;
    }
}