#include <iostream>
#include <iomanip>
#include <string>
using namespace std;


int main()
{
    int A;
    int B;
    cin >> A>>B;
    int bSize = to_string(B).length();
    int numArr = 10;
    int numbLine = 1;
    for (int i = 0; i < bSize; i++)
    {
        if (i != 0)
        {
            numbLine = numArr;
            numArr *= 10;
        }
        int targetLine = B % numArr;
        cout << (targetLine / numbLine)*A << endl;
    }
    cout << A*B << endl;
    return 0;
}


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


