#include <stdio.h>


//ʹ��һά���鱣��10���ɼ�������߷֣���ͷֺ�ƽ���֡�
int main(){
	float a[10];
	float sum = 0.0,max,min;
	int i;
	for(i=0;i<=9;i++){
		scanf("%f",&a[i]);
		sum += a[i];
	}
	
	max = a[0];
	for(i=1;i<=9;i++){
		if(a[i]>max){
			max = a[i];
		}
	}
	
	min = a[0];
	for(i=1;i<=9;i++){
		if(a[i]<min){
			min = a[i];
		}
	}
	
	printf("%f",sum);
	printf("\n");
	printf("���ֵ:%.2f,��Сֵ:%.2f,ƽ��ֵ��%.2f",max,min,sum/10);
	
    return 0;
}

