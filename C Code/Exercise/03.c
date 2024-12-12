#include <stdio.h>

//.使用递归求斐波那契中的第n项


//1 1 2 3 5 8 ....
long long Feb(int n){
	if(n==1 || n==2)return 1;
	if(n >=3){
		return Feb(n-2)+Feb(n-1);
	}
	
	
}

int main(){

	int n;
	scanf("%d",&n);
	printf("%d\n",Feb(n));
    return 0;
}

