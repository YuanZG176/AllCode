#include <stdio.h>



//��дһ�����򣬽����û������һά����ĳ��Ⱥ�����Ԫ�أ�������һ��Ŀ��ֵ��
//���Ҹ�ֵ�Ƿ��������У��������������������ڣ������������δ�ҵ�����
int main(){
	int a[100],k,f;
	int n;
	printf("������Ԫ�ظ�����");
	scanf("%d",&n);
	printf("����������Ԫ�أ�"); 
	int i;
	for(i = 0;i<n;i++){
		scanf("%d",&a[i]);
	} 
	printf("��������Ҫ����Ԫ�أ�");
	scanf("%d",&k);
	f=0;
	for(i=0;i<n;i++){
		if(a[i] == k){
			printf("%d������a�ĵ�%d��Ԫ��.",k,i+1);
			f=1;
			break;
		}
	}
	if(f==0)printf("%d������",k);
    return 0;
}
