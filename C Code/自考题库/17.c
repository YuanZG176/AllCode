#include <stdio.h>

int main(){
	char ch = 'a';
	ch = (ch >= 'a' && ch <= 'z') ? (ch - 32) : ch;
	printf("%c",ch);

    return 0;
}

