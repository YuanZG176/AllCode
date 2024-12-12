//#include<stdio.h>
//main()
//{
//int x=l,y=0,a=0,b=0;
//switch(x)
//{casel：
//switch(y)
//{case0:a++;break;
//case1：b++；break；}
//case2：
//a++；b++;break；}
//printf("a=％d,b=％d\n",a,b);
//}



#include <stdio.h>
main()
{
    int x=1, y=0, a=0, b=0;  // 注意：x 的初始值是 1，不是 l
    switch(x)
    {
        case 1:  // 注意：case 后面没有分号
            switch(y)
            {
                case 0:
                    a++;  // 当 y 为 0 时，a 自增
                    break;
                case 1:
                    b++;  // 当 y 为 1 时，b 自增
                    break;
            }
            // 注意这里没有 break 语句，所以会继续执行 case 2 的代码
        case 2:
            a++;  // a 再次自增
            b++;  // b 自增
            break;  // 退出 switch 语句
    }
    printf("a=%d, b=%d\n", a, b);  // 打印 a 和 b 的值  a=2, b=1
}
