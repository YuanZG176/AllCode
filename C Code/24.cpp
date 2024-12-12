#include <stdio.h>

int main() {
    int scores[10];  // 用于存储10门课程的得分
    int max_score, min_score;

    // 提示用户输入每门课程的得分
    printf("请输入10门课程的得分:\n");
    int i;
    for ( i = 0; i < 10; i++) {
        printf("课程 %d 得分: ", i + 1);
        scanf("%d", &scores[i]);
    }

    // 初始化最大分和最小分
    max_score = scores[0];
    min_score = scores[0];

    // 查找最大分和最小分

    for (i = 1; i < 10; i++) {
        if (scores[i] > max_score) {
            max_score = scores[i];
        }
        if (scores[i] < min_score) {
            min_score = scores[i];
        }
    }

    // 输出结果
    printf("该同学的最高分是: %d\n", max_score);
    printf("该同学的最低分是: %d\n", min_score);

    return 0;
}

