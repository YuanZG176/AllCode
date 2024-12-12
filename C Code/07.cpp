#include <stdio.h> 

int main(){

	int n,day = 0,s=0;
	scanf("%d",&n);
	
	while(s<n){
		day++;
		s+=day;
	}

	printf("%d",day);



return 0;

}
