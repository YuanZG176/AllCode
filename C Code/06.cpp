#include <stdio.h> 

int main(){

int i,n;
double sum=0.0,a;
printf("������һ�ܵ�����:");
scanf("%d",&n);

for(i=1;i<=n;i++){
	printf("�������%d�������",i);
	scanf("%lf",&a);
	sum += a;
}
printf("һ�ܵ�ƽ������Ϊ%.2lf",sum/7);
return 0;

}
