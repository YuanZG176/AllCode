#include <stdio.h>

int main(){
	long long s = 0,a=1;
	int i ;
	for(i=1;i<=20;i++){
		a = a*i;
		s=s+a;
	}
	printf("%lld",s);
    return 0;
}

