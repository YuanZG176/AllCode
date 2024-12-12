//39、下面程序的运行结果是___________。
//#include<stdio．h>
//main()
//{int i=1;
//	do{i--;}while(i++);
//	print f("%d",i--);}
//A、-1
//B、0
//C、1
//D、陷入死循环
//正确答案：C




//第一次循环:

    //初始 i 为 1。
    //执行 i--，i 变为 0。
    //检查 i++，此时 i 为 0，0 为假，所以循环终止。
    //但 i++ 会使 i 自增 1，所以 i 变为 1

#include <stdio.h>

main() {
    int i = 1;
    do {
        i--;
    } while (i++);
    printf("%d", i--);
}
