#include <stdio.h>


// π”√µ›πÈ«Ûn£°

long long jiecheng(int n){
	if(n==1){
		return 1;
	}else{
		return n*jiecheng(n-1);
	}
}

int main(){
	int n;
	scanf("%d",&n);
	
	printf("%lld\n",jiecheng(n));
    return 0;
}

