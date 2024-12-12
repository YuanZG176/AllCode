#include <stdio.h>

int main(){
	int a,b;
	int* p,*q;
	p = &a;
	q = &b;
	a = 2,b=3;
	printf("%d\n变量a的地址为%d\n",a,&a);
	printf("%d\n变量b的地址为%d\n",b,&b);
	
	printf("*p=%d\np=%d",*p,p);
	printf("*q=%d\nq=%d",*q,q);
    return 0;
}

