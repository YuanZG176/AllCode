#include <stdio.h>

//�����ֳ�������һ������1����Ȼ��������1���������⣬
//���ܱ�������Ȼ������������������
int main(){
	int i,n,k=1;
	scanf("%d",&n);//n=9
	for(i = 2;i<n;i++){
		if(n%i==0){
			k=0;
			break;
		}
	}
	if(k==1){
		printf("Yes");
	}else{
		printf("No");
	}

   return 0;
}

