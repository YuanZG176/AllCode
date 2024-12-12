#include <stdio.h>

int main(){
	
	int a,b,c,k=0;
	scanf("%d %d %d",&a,&b,&c);
	if(a>=90){
		k++;
	}
		if(b>=90){
		k++;
	}
		if(c>=90){
		k++;
	}
	
	printf("%d",k);
	

	return 0;
}

