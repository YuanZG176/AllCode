#include <stdio.h>

int main(){

	int a[10]  ={2,5,7,8,9,1,24,67,8,9};
	int i;
	for(i=0;i<=9;i++){
		printf("%d ",a[i]);
	} 
	printf("\n");
	
	int *p;
	p = a;
	printf("%d\n",a);
	printf("%d\n",p);
//	printf("%d\n",p+1);
//	printf("%d\n",p+2);

for(i=0;i<=9;i++){
	printf("%d ",*(p+i));
}
    return 0;
}

