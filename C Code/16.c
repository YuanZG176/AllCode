#include <stdio.h>
//�ټ���Ǯ���ҹ��Ŵ���ѧ�������ڡ��㾭��һ�����������ѧ���⣺������һֵǮ�壬��ĸһֵǮ����������ֵǮһ��
//��Ǯ��ټ����ʼ��̡���ĸ�����������Σ���
int main(){
	int i,j,k;
	for(i=1;i<=98;i++){
		for(j=1;j<=98;j++){
			k=100-i-j;
			if(k<=0 || k%3 !=0)continue;
			if(5*i+3*j+k/3==100){
				printf("%d %d %d\n",i,j,k);
			}
		}
	}
    return 0;
}
