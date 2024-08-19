using System;
//카드는 총 100장, 2이상 100이하의 숫자를 하나 정해
//그보다 작은 숫자의 카드들을 준비,준비된 카드 수 만큼 작은 상자의 집합 A가 존재
//A들에 카드를 넣고 무작위로 섞어 일렬로 나열
//그 중 임의의 상자를 하나 열어 카드값을 확인 =>{그 카드값 번째의 상자를 열어 숫자를 확인} 
//if 열어야 하는 상자가 이미 열린 상태라면 다음 2번 그룹을 수집하기 시작  
public class Solution {
    
    public int solution(int[] cards) {
        int answer = 0;
        bool[] isOpenedCards = new bool[cards.Length];
        int[] cardNumberGroups = new int[0];
        int currentCardNumber = 1;
        for(int i = 0; i<cards.Length; i++)
        {
            if(isOpenedCards[i] == false)
            {
                currentCardNumber = i+1;
                Array.Resize(ref cardNumberGroups, cardNumberGroups.Length+1);
                Console.WriteLine(cardNumberGroups.Length);
                while(!isOpenedCards[currentCardNumber-1])
                {
                    cardNumberGroups[cardNumberGroups.Length-1]++;
                    Console.WriteLine("ㅇㅇ"+cardNumberGroups[cardNumberGroups.Length-1]);
                    isOpenedCards[currentCardNumber-1] = true;
                    currentCardNumber = cards[currentCardNumber-1];
                }
            }
        }
        Array.Sort(cardNumberGroups,(num1, num2) => num2.CompareTo(num1));
        if(cardNumberGroups.Length>=2)return cardNumberGroups[0]*cardNumberGroups[1];
        else return 0;
    }
}