#include <stdio.h>


long long jc(int n){
	if(n==1){
		return 1;
	}else{
		return n*jc(n-1);
	}
} 
int main(){
	int m,n;
	scanf("%d %d",&m,&n);
	printf("%lld",jc(m)+jc(n));

    return 0;
}

