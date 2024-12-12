#include <stdio.h>
int main(){
	int a,n,i,k,s=0;
	scanf("%d %d",&a,&n);
	k=a;
	for(i=1;i<=n;i++){
		s=s+k;
		k = k*10+a;
	}
	printf("%d",s);
    return 0;
}

