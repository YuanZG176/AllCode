//66、有以下程序
//	#include<stdio.h>
//	#include<string.h>
//	void main()
//	{
//		char a[7]="a0\0a0\0";int i,j;
//		i=sizeof(a);j=strlen(a);
//		print f("%d%d\n",i,j);
//	}
//程序运行后的输出结果是______。
//A、22
//B、76
//C、72
//D、62
//正确答案：C



	#include<stdio.h>
	#include<string.h>
	void main()
	{
		char a[7]="a0\0a0\0";int i,j;
		i=sizeof(a);j=strlen(a);
		printf("%d%d\n",i,j);
	}
