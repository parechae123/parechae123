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


