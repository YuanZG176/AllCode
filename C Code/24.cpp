#include <stdio.h>

int main() {
    int scores[10];  // ���ڴ洢10�ſγ̵ĵ÷�
    int max_score, min_score;

    // ��ʾ�û�����ÿ�ſγ̵ĵ÷�
    printf("������10�ſγ̵ĵ÷�:\n");
    int i;
    for ( i = 0; i < 10; i++) {
        printf("�γ� %d �÷�: ", i + 1);
        scanf("%d", &scores[i]);
    }

    // ��ʼ�����ֺ���С��
    max_score = scores[0];
    min_score = scores[0];

    // �������ֺ���С��

    for (i = 1; i < 10; i++) {
        if (scores[i] > max_score) {
            max_score = scores[i];
        }
        if (scores[i] < min_score) {
            min_score = scores[i];
        }
    }

    // ������
    printf("��ͬѧ����߷���: %d\n", max_score);
    printf("��ͬѧ����ͷ���: %d\n", min_score);

    return 0;
}

