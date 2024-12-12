#include <stdio.h> 

int main(){

int i,n;
double sum=0.0,a;
printf("请输入一周的天数:");
scanf("%d",&n);

for(i=1;i<=n;i++){
	printf("请输入第%d天的消费",i);
	scanf("%lf",&a);
	sum += a;
}
printf("一周的平均消费为%.2lf",sum/7);
return 0;

}
