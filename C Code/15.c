#include <stdio.h>
//输出乘法九九口诀表。
int main(){
	int  i,j;
	for(i=1;i<=9;i++){
		for(j=1;j<=i;j++){
			printf("%d * %d = %d  ",j,i,i*j);
		}
		printf("\n");
	}
    return 0;
}

