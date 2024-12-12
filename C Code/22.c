#include <stdio.h>

int main(){


	float a,s=0;
	float max = 0,min = 200;
	int i;
	for(i=0;i<=10;i++){
		scanf("%f",&a);
		if(a>max){
			max = a;
		}
		if(a<max){
			min = a;
		}
		s=s+a;
	}
	printf("平均分为: %.2f,最大值为:%.2f,最小值为:%.2f",s/10,max,min);
    return 0;
}

