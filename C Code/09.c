#include <stdio.h>
//求Fibonacci(斐波那契)数列的前40个数。
int main(){
	long long fib[40];
	fib[0] = 0;
	fib[1] = 1;
	int i;
	for(i=2;i<40;i++){
		fib[i]= fib[i-1]+fib[i-2];
	} 
	
	printf("斐波拉契的前40个数是:\n");
	for(i=0;i<40;i++){
		printf("%lld ",fib[i]);
	}
	printf("\n");
    return 0;
}

