#include <stdio.h>
void add(int a){
	a++;
} 

void add2(int a[],int n){
	int i;
	for(i=0;i<n;i++){
		a[i]++;
	}
}
int main(){

	int x =2;
	add(2);
	printf("%d\n",x);
	int a[5]  ={3,4,6,7,8};
	add2(a,5);
	int i;
	for(i=0;i<5;i++){
		printf("%d ",a[i]);
	}

    return 0;
}

