#include <stdio.h>

int main(){
//课后习题5：【数组倒置】将一个数组中的值按逆序重新存放。例如，原来顺序为8,6,5,4,1；要求改为1,4,5,6,8.
	
	int a[6];
	int i;
	for(i=0;i<=5;i++){
		scanf("%d",&a[i]);
	}
//	for(i=0;i<=2;i++){
//		a[i] = a[5-i];
//		printf("%d ",a[i]);
//	}
	
	
		for(i=0;i<=2;i++){
		int	t = a[i];
			a[i] = a[5-i];
			a[5-i] = t;
			//printf("%d ",a[i]);
		}
	
	printf("\n");
	for(i=0;i<=5;i++){
		printf("%d ",a[i]);
	}
	
	
    return 0;
}

