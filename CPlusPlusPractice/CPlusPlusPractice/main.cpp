#include <iostream>


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
void main() 
{
    int a;
    std::cout << INT32_MAX << std::endl;
    scanf_s("%i", &a);
    std::cout << a << std::endl;
}