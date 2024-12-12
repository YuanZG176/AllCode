#include <stdio.h>
#define MAXCOUNT 1000
	int main(){
		double a,total = 0;
		int k  = 0;
		int i = 1;
		for( i = 1;i<=10;i++){
			if(total>=MAXCOUNT){
				printf("已达到最大捐款限度\n");
				break;
			}
			printf("请输入捐款金额:");
			scanf("%lf",&a);
			if(a>200){
				printf("金额太多，拒收！！！\n");
				continue;
			}
			total += a;
			k++;
		}
	printf("捐款总额为:%lf,捐款人数为:%d,人均捐款数额:%lf",total,k, total/k);
	return 0;
}
