#include <stdio.h>

//质数又称素数。一个大于1的自然数，除了1和它自身外，
//不能被其他自然数整除的数叫做质数
int main(){
	int i,n,k=1;
	scanf("%d",&n);//n=9
	for(i = 2;i<n;i++){
		if(n%i==0){
			k=0;
			break;
		}
	}
	if(k==1){
		printf("Yes");
	}else{
		printf("No");
	}

   return 0;
}

