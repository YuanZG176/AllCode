#include <stdio.h>
//百鸡百钱是我国古代数学家张丘建在《算经》一书中提出的数学问题：“鸡翁一值钱五，鸡母一值钱三，鸡雏三值钱一。
//百钱买百鸡，问鸡翁、鸡母、鸡雏各几何？”
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

