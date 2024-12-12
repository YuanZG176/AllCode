#include <stdio.h>
int max(int a, int b);

int main(){
	int m, n;
	scanf("%d %d",&m,&n);
	printf("%d和%d中的较大者为%d",m,n,max(m,n));

    return 0;
}

int max(int a,int b){
	if(a>b) return a;
	return b;
}

