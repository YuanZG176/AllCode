//56、有以下程序
//	#include<stdio.h>
//	void  main()
//	{
//		char  p[]={'a','b','c'},q[]="abc";
//		print f("%d%d\n",sizeof(p),sizeof(q));
//	}
//	程序运行后的输出结果是______。
//A、44
//B、33
//C、34
//D、43
//正确答案：C



#include<stdio.h>
	void  main()
	{
		char  p[]={'a','b','c'},q[]="abc";
		printf("%d%d\n",sizeof(p),sizeof(q));
	}
