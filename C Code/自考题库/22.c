#include <stdio.h>

int main() {
    float a;

    // ִ�б��ʽ a=1, a++, a+=a
    a = 1, a++, a += a;

    // ��ӡ���յ� a ֵ
    printf("a = %f\n", a);

    return 0;
}
