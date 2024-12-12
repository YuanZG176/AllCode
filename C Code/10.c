#include <stdio.h>
#include <math.h>
//编程题】用公式π/4≈1 - 1/3 + 1/5 - 1/7 + ?求π的近似值，
//直到发现某一项的绝对值小于10-6次方为止(该项不累加)。
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

