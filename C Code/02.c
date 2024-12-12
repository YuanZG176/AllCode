#include <stdio.h>
int main(){
	
	int a,k=0;
	int i = 1;
//
//while(i<=10){
//	scanf("%d",&a);
//	if(a>=90){
//		k++;
//		
//	}
//	i++;
//}



for(i= 1;i<=10;i++){
	scanf("%d",&a);
	if(a>=90)k++;
}
printf("优秀课程的个数为%d",k);
	return 0;
} 

