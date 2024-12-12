#include <stdio.h>
#include <stdbool.h>

// �������ж�һ�����Ƿ�������
bool is_prime(int num) {
    if (num <= 1) {
        return false; // 1 ��������
    }
    int i;
    for (i = 2; i * i <= num; i++) {
        if (num % i == 0) {
            return false; // ��������������
        }
    }
    return true; // û������������ true
}

int main() {
    printf("100��200֮��������У�\n");
    int i;
    // ����100��200֮��������ж��Ƿ�Ϊ����
    for (i = 100; i <= 200; i++) {
        if (is_prime(i)) {
            printf("%d ", i); // �������
        }
    }
    
    printf("\n");
    return 0;
}

