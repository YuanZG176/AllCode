//38、以下程序的输出结果是___________。
//	#include<stdio.h>
//	#include<string.h>
//	void  main()
//	{
//		char st[20]="hello\0\t\\";
//		print f("%d%d\n",strlen(st),sizeof
//
//(st));
//}
//A、99
//B、520
//C、1320
//D、2020
//正确答案：B




#include <stdio.h>
#include <string.h>

void main() {
    char st[20] = "hello\0\t\\";
    printf("%d %d\n", strlen(st), sizeof(st));
}
