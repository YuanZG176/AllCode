#include <stdio.h>

int main(){

	int x = 10;
	int y = (x -= x+x);
	printf("%d",y);
//printf(x -= x+x);���� 
    return 0;
}

