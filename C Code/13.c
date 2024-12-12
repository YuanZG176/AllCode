#include <stdio.h>

int main(){
	int n,m;
	char c;
	scanf("%d %d",&n,&m);
	getchar();
	c=getchar();
	int i,j;
	for(j=1;j<=m;j++){
		for(i = 1;i<=n;i++){
			printf("%c",c);
		}
		printf("\n");
	}
    return 0;
}

