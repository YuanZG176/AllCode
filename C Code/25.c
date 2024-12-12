#include <stdio.h>

int main(){
	int a[10];
	a[0] = 10;
	a[1] = 8;
	int i;
	for( i=2;i<=9;i++){
		scanf("%d",&a[i]);
	}
	for(i=0;i<10;i++){
		printf("%d ",a[i]);
	}
	
	
	printf("\n");
	
	
	for(i=9;i>=0;i--){
		printf("%d ",a[i]);
	}
    return 0;
}

