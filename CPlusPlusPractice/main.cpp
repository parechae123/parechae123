#include <iostream>

int sum(int a, int b) {
    return a + b;
}

int main() {
    int (*sumPtr)(int, int); // �Լ� ������ ����
    sumPtr = &sum; // �Լ� �ּ� �Ҵ�

    // �Լ� �����͸� ����Ͽ� �Լ� ȣ��
    int result = sumPtr(10, 20);
    std::cout << "Result: " << result << std::endl;

    return 0;
}
