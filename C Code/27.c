#include <stdio.h>

int main(){
//�κ�ϰ��5�������鵹�á���һ�������е�ֵ���������´�š����磬ԭ��˳��Ϊ8,6,5,4,1��Ҫ���Ϊ1,4,5,6,8.
	
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

