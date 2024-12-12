#include <stdio.h>

int main(){
	int sum = 0,i = 1;
	do{
		sum+=i;
		i++;
	} while(i<=100); 
	printf("%d",sum);
    return 0;
}

