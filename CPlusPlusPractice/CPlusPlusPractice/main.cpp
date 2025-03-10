#include <iostream>
#include <string>
#include <array>

using namespace std;

int main()
{
	int numbers[3];
	cin >> numbers[0] >> numbers[1] >> numbers[2];

	int sameNumberCount = 0;
	int higherstNumber = 0;
	int sameNumber = numbers[0];
	for (int i = 0; i < sizeof(numbers) / sizeof(numbers[0]); i++)
	{
		if (numbers[i] > 6 || numbers[i] <= 0)
		{
			return 0;
		}
		for (int e = i+1; e < sizeof(numbers) / sizeof(numbers[0]); e++)
		{

			higherstNumber = numbers[i] > higherstNumber? numbers[i] : higherstNumber;
			higherstNumber = numbers[e] > higherstNumber? numbers[e] : higherstNumber;
			if (numbers[i] == numbers[e])
			{
				sameNumberCount++;
				sameNumber = numbers[i];
			}
		}
	}
	int outputNumber;
	if (sameNumberCount == 0)
	{
		outputNumber = higherstNumber * 100;
	}
	else if (sameNumberCount == 1)
	{
		outputNumber = (sameNumber * 100)+1000;
	}
	else if (sameNumberCount >= 2)
	{
		outputNumber = (sameNumber * 1000) + 10000;
	}
	cout << outputNumber << endl;
	//같은 눈이 3개가 나오면 10, 000원 + (같은 눈)×1, 000원의 상금을 받게 된다.
	//	같은 눈이 2개만 나오는 경우에는 1, 000원 + (같은 눈)×100원의 상금을 받게 된다.
	//	모두 다른 눈이 나오는 경우에는(그 중 가장 큰 눈)×100원의 상금을 받게 된다.
}



/*

struct Time
{
	short hour;
	short minit;
};

Time CarculateTime(Time originTime, short plusTime)
{
	short remainHour = (originTime.minit + plusTime)/ 60;
	short remainMinit = (originTime.minit + plusTime) % 60;
	originTime.hour += remainHour;
	originTime.minit = remainMinit;
	if (originTime.hour >= 24)
	{
		originTime.hour -= 24;
	}
	return originTime;
}


int main()
{
	Time enteredTime;
	cin >> enteredTime.hour >> enteredTime.minit;
	short targetTIme;
	cin >> targetTIme;
	if (enteredTime.hour > 23 || enteredTime.hour < 0)
	{
		return 0;
	}
	if (enteredTime.minit > 60 || enteredTime.minit < 0)
	{
		return 0;
	}
	if (targetTIme > 1000 || targetTIme < 0)
	{
		return 0;
	}
	enteredTime = CarculateTime(enteredTime, targetTIme);
	cout <<enteredTime.hour;
	cout <<" ";
	cout << enteredTime.minit << endl;

	return 0;
}

*/

/*
struct Time
{
	short hour;
	short minit;
};

Time CarculateTime(Time originTime, short minusTime)
{
	if (originTime.minit < minusTime)
	{
		if (originTime.hour == 0)
		{
			originTime.hour = 23;
		}
		else
		{
			originTime.hour -= 1;
		}


		originTime.minit = 60 + (originTime.minit - minusTime);
	}
	else
	{
		originTime.minit = originTime.minit - minusTime;
	}
	return originTime;
}


int main() 
{
	Time enteredTime;
	cin >> enteredTime.hour >> enteredTime.minit;
	if (enteredTime.hour > 23 || enteredTime.hour < 0)
	{
		return 0;
	}
	if (enteredTime.minit > 60 || enteredTime.minit < 0)
	{
		return 0;
	}
	enteredTime = CarculateTime(enteredTime, 45);
	cout <<enteredTime.hour;
	cout <<" ";
	cout << enteredTime.minit << endl;

	return 0;
}*/

/*
int main() 
{
//사분면 문제
	short X, Y;
	cin >> X >> Y;
	if ((X != 0 && Y != 0)
		&&	(X >= -1000 && X <= 1000)
		&&	(Y >= -1000 && Y <= 1000)
		)
	{
		cout << (X > 0 ? (Y > 0 ? 1 : 4) : (Y > 0 ? 2 : 3)) << endl;
	}
	else
	{
		return 0;
	}
	return 0;
}*/
/*
int main() 
{
	윤년문제
	short A;
	
	cin >> A;
	cout << ((A % 4 == 0 && (A % 100) != 0) || A % 400 == 0 ? 1 : 0) <<endl;
	return 0;
}*/

//int main()
//{
//    int A;
//    int B;
//    cin >> A>>B;
//    int bSize = to_string(B).length();
//    int numArr = 10;
//    int numbLine = 1;
//    for (int i = 0; i < bSize; i++)
//    {
//        if (i != 0)
//        {
//            numbLine = numArr;
//            numArr *= 10;
//        }
//        int targetLine = B % numArr;
//        cout << (targetLine / numbLine)*A << endl;
//    }
//    cout << A*B << endl;
//    return 0;
//}


int sum(int a, int b) {
    return a + b;
}

//int main() {
//    int (*sumPtr)(int, int); // 함수 포인터 선언
//    sumPtr = &sum; // 함수 주소 할당
//
//    // 함수 포인터를 사용하여 함수 호출
//    int result = sumPtr(10, 20);
//    std::cout << "Result: " << result << std::endl;
//
//    return 0;
//}

//
//void main()
//{
//    int a;
//    std::cout << INT32_MAX << std::endl;
//    scanf_s("%i", &a);
//    //입력을 감지하는 함수호출,앞에 스트링으로 받는 값은 Int로 입력을 받는단뜻
//    //&a의 &가 붙으면 해당 변수의 주소값을 가져오는것
//    std::cout << a << std::endl;
//}


