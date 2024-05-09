#include <iostream>

int sum(int a, int b) {
    return a + b;
}

int main() {
    int (*sumPtr)(int, int); // 함수 포인터 선언
    sumPtr = &sum; // 함수 주소 할당

    // 함수 포인터를 사용하여 함수 호출
    int result = sumPtr(10, 20);
    std::cout << "Result: " << result << std::endl;

    return 0;
}
