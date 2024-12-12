#include <stdio.h>

int main(){
	int n;
	char c;
	scanf("%d",&n);
	getchar();
	c=getchar();
	int i,j;
	for(j=1;j<=n;j++){
		for(i = 1;i<=j;i++){
			printf("%c",c);
		}
		printf("\n");
	}
    return 0;
}

