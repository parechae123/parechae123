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
	//���� ���� 3���� ������ 10, 000�� + (���� ��)��1, 000���� ����� �ް� �ȴ�.
	//	���� ���� 2���� ������ ��쿡�� 1, 000�� + (���� ��)��100���� ����� �ް� �ȴ�.
	//	��� �ٸ� ���� ������ ��쿡��(�� �� ���� ū ��)��100���� ����� �ް� �ȴ�.
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
//��и� ����
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
	���⹮��
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
//    int (*sumPtr)(int, int); // �Լ� ������ ����
//    sumPtr = &sum; // �Լ� �ּ� �Ҵ�
//
//    // �Լ� �����͸� ����Ͽ� �Լ� ȣ��
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
//    //�Է��� �����ϴ� �Լ�ȣ��,�տ� ��Ʈ������ �޴� ���� Int�� �Է��� �޴´ܶ�
//    //&a�� &�� ������ �ش� ������ �ּҰ��� �������°�
//    std::cout << a << std::endl;
//}


