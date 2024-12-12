#include <stdio.h>

int main(){
	int a,b,c,d;
	scanf("%d %d %d",&a,&b, &c);
//	if (a>=b){
//		c =a;
//	}else{
//		c= b;
//	}


	c = a>=b?a:b;
	d = d>c?d:c;
	printf("%d",d);
	
	
	return 0;
	
}

