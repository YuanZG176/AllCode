#include <stdio.h>
#define N 20
int main(){
	int a[N] = {0},k,f,index;
	int n;
	printf("������Ԫ�ظ�����");
	scanf("%d",&n);
	printf("����������Ԫ�أ�");
	int i;
	for(i=0;i<n;i++){
		scanf("%d",&a[i]);
	}
	printf("��������Ҫ�����Ԫ���Լ�Ԫ�ص�λ�ã�");
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

