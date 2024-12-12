#include <stdio.h>
#include <math.h>
int add(int a,int b ){
	return a+b;
}
int add3(int a,int b,int c){
	int t  =add(a,b);
	t = add(t,c);
	return t;
}


void sayHello(){
	printf("SayHello。。。");
}
int sub(int a,int b ){
	return a-b;
}

int main(){
	printf("两个数的和: %d\n",add(5,6));
	printf("两个数的差: %d\n",sub(5,6));
	printf("%d\n",add(8,0));
	int a = add3(6,7,8);
	printf("%d\n",a);
	printf("%.2f\n",pow(2,10));
	sayHello();
    return 0;
}

