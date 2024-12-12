#include <stdio.h>

//“水仙花数”是一种三位数，其各位数的立方和等于该数。
//例如：153=13+53+33。
//编写程序，输出所有水仙花数。补齐以下代码实现相应功能。
int main(){
	int i,j,k;
	for(i=1;i<=9;i++){
		for(j=0;j<=9;j++){
			for(k=0;k<=9;k++){
				int a = i*100+j*10+k;
				if(i*i*i+j*j*j+k*k*k==a){
					printf("水仙花数为: %d \n",a);
				}
				
		}
		}
		}
    return 0;
}

