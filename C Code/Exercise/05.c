#include <stdio.h>

int swap(int *a,int *b){
	int t  = *a;
	*a = *b;
	*b = t;
}
int main(){
	int a,b;
	scanf("%d %d",&a,&b);
	swap(&a,&b);
	printf("½»»»ºó: a = %d, b = %d\n", a, b);

    return 0;
}

