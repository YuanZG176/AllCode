
//24、下面的程序，描述正确的是___________。
//main()
//	{int x=3;
//	do
//	{print f("%d\n",x-=2);}
//	while(!(--x));}
//A、输出的是1
//B、输出的是1和-2
//C、输出的是3和0
//D、是死循环
//正确答案：B





//在C语言中，数值0被视为假（false），而任何非零值都被视为真（true）。

#include <stdio.h>

main()
{
    int x = 3;
    do
    {
        printf("%d\n", x -= 2);
    } while (!(--x));
}

