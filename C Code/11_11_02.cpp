#include <stdio.h>

int main(){
	
	int a,b,c;
	scanf("%d %d %d",&a,&b,&c);
	if(a+b<=c || a+c<=b || b+c <= a){
		printf("���ܹ���������");
	}else if(a==b&& b==c){
		printf("�ܹ��ɵȱ�������");
	}else if(a==b || a==c || b==c){
		printf("�ܹ��ɵ���������");
	}
	else{
		printf("��ͨһ��������");
	}
	
	
	return 0;
}
