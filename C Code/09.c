#include <stdio.h>
//��Fibonacci(쳲�����)���е�ǰ40������
int main(){
	long long fib[40];
	fib[0] = 0;
	fib[1] = 1;
	int i;
	for(i=2;i<40;i++){
		fib[i]= fib[i-1]+fib[i-2];
	} 
	
	printf("쳲�������ǰ40������:\n");
	for(i=0;i<40;i++){
		printf("%lld ",fib[i]);
	}
	printf("\n");
    return 0;
}

