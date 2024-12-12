#include <stdio.h>

void sort(int *a, int n) {
    int i, j;
    for(i = 0; i < n - 1; i++) {
        for(j = 0; j < n - i - 1; j++) {
            if(*(a + j) < *(a + j + 1)) {
                int t = *(a + j);
                *(a + j) = *(a + j + 1);
                *(a + j + 1) = t;
            }
        }
    }
}

int main() {
    int n;
    int a[100];
    printf("请输入元素个数: ");
    scanf("%d", &n);  // 不要在 %d 后加空格

    if (n > 100) {
        printf("数组大小超过限制（最大为 100）\n");
        return 1;  // 退出程序，避免数组越界
    }

    int i;
    printf("请输入 %d 个整数:\n", n);
    for(i = 0; i < n; i++) {
        scanf("%d", a + i);  // 修正输入方式
    }
    
    sort(a, n);
    
    printf("排序后的结果:\n");
    for(i = 0; i < n; i++) {
        printf("%d ", *(a + i));
    }
    printf("\n");

    return 0;
}

