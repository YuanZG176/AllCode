#include <stdio.h>

int main(){
	
	int a,b,c;
	scanf("%d %d %d",&a,&b,&c);
	if(a+b<=c || a+c<=b || b+c <= a){
		printf("不能构成三角形");
	}else if(a==b&& b==c){
		printf("能构成等边三角形");
	}else if(a==b || a==c || b==c){
		printf("能构成等腰三角形");
	}
	else{
		printf("普通一般三角形");
	}
	
	
	return 0;
}
