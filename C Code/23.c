#include <stdio.h>
#include <stdbool.h>

// 函数：判断一个数是否是素数
bool is_prime(int num) {
    if (num <= 1) {
        return false; // 1 不是素数
    }
    int i;
    for (i = 2; i * i <= num; i++) {
        if (num % i == 0) {
            return false; // 有因数则不是素数
        }
    }
    return true; // 没有因数，返回 true
}

int main() {
    printf("100到200之间的素数有：\n");
    int i;
    // 遍历100到200之间的数，判断是否为素数
    for (i = 100; i <= 200; i++) {
        if (is_prime(i)) {
            printf("%d ", i); // 输出素数
        }
    }
    
    printf("\n");
    return 0;
}

