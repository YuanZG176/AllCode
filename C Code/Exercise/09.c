#include <stdio.h>
int max(int a, int b);

int main(){
	int m, n;
	scanf("%d %d",&m,&n);
	printf("%d��%d�еĽϴ���Ϊ%d",m,n,max(m,n));

    return 0;
}

int max(int a,int b){
	if(a>b) return a;
	return b;
}

