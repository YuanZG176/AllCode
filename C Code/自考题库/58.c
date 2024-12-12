//58、有以下程序段：
//	int i,j;
//	for(i=0;i<5;++i)
//	for(j=i;j<5;++j)
//print f("*");
//	则执行以上的程序片段后，输出'*'个数是___________。
//A、15
//B、10
//C、25
//D、20
//正确答案：A



	
#include <stdio.h>
main()
{
	int i,j;
	for(i=0;i<5;++i){
			for(j=i;j<5;++j){
				    printf("*");
			}
	}



} 

