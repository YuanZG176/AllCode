#include <stdio.h>

int main() {
    float a;

    // 执行表达式 a=1, a++, a+=a
    a = 1, a++, a += a;

    // 打印最终的 a 值
    printf("a = %f\n", a);

    return 0;
}
