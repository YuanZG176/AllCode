#include <stdio.h>
#define MAXCOUNT 1000
	int main(){
		double a,total = 0;
		int k  = 0;
		int i = 1;
		for( i = 1;i<=10;i++){
			if(total>=MAXCOUNT){
				printf("�Ѵﵽ������޶�\n");
				break;
			}
			printf("����������:");
			scanf("%lf",&a);
			if(a>200){
				printf("���̫�࣬���գ�����\n");
				continue;
			}
			total += a;
			k++;
		}
	printf("����ܶ�Ϊ:%lf,�������Ϊ:%d,�˾��������:%lf",total,k, total/k);
	return 0;
}
