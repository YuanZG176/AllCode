//20、有下列程序段：
//char ch;
//int s=0;
//for(ch='A';ch<'Z';++ch)
//if(ch%2==0)s++;
//	print f("%d",s);
//	则执行上述片段后，程序的输出结果是___________。
//A、13
//B、12
//C、26
//D、25
//正确答案：A


#include <stdio.h>

int main() {
    char ch;
    int s = 0;
    for (ch = 'A'; ch <= 'Z'; ++ch) {  // 注意：条件应该是 ch <= 'Z'
        if (ch % 2 == 0) {
            s++;
        }
    }
    printf("%d\n", s);  // 注意：printf 的格式字符串         字符 'A' 到 'Z' 的 ASCII 码分别是 65 到 90。

    return 0;
}

