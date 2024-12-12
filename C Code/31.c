#include <stdio.h>
#define N 20
int main(){
	int a[N] = {0},k,f,index;
	int n;
	printf("请输入元素个数：");
	scanf("%d",&n);
	printf("请输入所以元素：");
	int i;
	for(i=0;i<n;i++){
		scanf("%d",&a[i]);
	}
	printf("请输入你要插入的元素以及元素的位置：");
	scanf("%d %d",&k,&index);
	for(i=n;i>=index;i--){
		a[i] = a[i-1];
	} 
	a[index-1] = k;
	for(i=0;i<n+1;i++){
		printf("%d ",a[i]);
	}
    return 0;
}

