//70、执行下面程序片段的结果是___________。
//int x=0;
//do
//	{printf("%2d",x--);}
//while(x);
//A、打印出321
//B、打印出23
//C、打印不确定结果
//D、陷入死循环
//正确答案：D





#include<stdio.h>
void main()
{

int x = 0;
do {
    printf("%2d", x--);
} while (x);

}
