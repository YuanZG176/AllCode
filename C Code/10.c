#include <stdio.h>
#include <math.h>
//����⡿�ù�ʽ��/4��1 - 1/3 + 1/5 - 1/7 + ?��еĽ���ֵ��
//ֱ������ĳһ��ľ���ֵС��10-6�η�Ϊֹ(����ۼ�)��
int main(){
	int sign = 1;
	double pi = 0.0,n=1.0,term=1.0;
	while(fabs(term)>=1e-6){
		pi += term;
		n = n+2;
		sign = -sign;
		term = sign/n;
	}
	pi = pi*4;
	printf("PI = %.5lf",pi);
	
    return 0;
}

