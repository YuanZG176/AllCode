//30、以下程序的输出结果是___________。
//#include<stdio．h>
//main()
//{int a=0，b=l，c=0，x=0，y=0；
//if(x<=y)
//if(y=l0)
//if(!b)a=1；
//else if(c)a=10；
//a=-1；
//print f("％d"，a)；}
//A、1
//B、0
//C、-1
//D、不确定的值
//正确答案：C




////在C语言中，数值0被视为假（false），而任何非零值都被视为真（true）。

#include <stdio.h>

main() {
    int a = 0, b = 1, c = 0, x = 0, y = 0;
    if (x <= y) {
        if (y = 10) {  // 注意这里的赋值操作
            if (!b) a = 1;
        } else if (c) {
            a = 10;
        }
    }
    a = -1;  // 最终将 a 赋值为 -1
    printf("%d", a);  // 打印 a 的值   -1
}
