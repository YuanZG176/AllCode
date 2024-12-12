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
    printf("������Ԫ�ظ���: ");
    scanf("%d", &n);  // ��Ҫ�� %d ��ӿո�

    if (n > 100) {
        printf("�����С�������ƣ����Ϊ 100��\n");
        return 1;  // �˳����򣬱�������Խ��
    }

    int i;
    printf("������ %d ������:\n", n);
    for(i = 0; i < n; i++) {
        scanf("%d", a + i);  // �������뷽ʽ
    }
    
    sort(a, n);
    
    printf("�����Ľ��:\n");
    for(i = 0; i < n; i++) {
        printf("%d ", *(a + i));
    }
    printf("\n");

    return 0;
}

