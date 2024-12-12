#include <stdio.h>

int main(){
	char name[20];
	char pw[20];
	printf("Enter your username:");
	gets(name);
	printf("Enter your password:");
	gets(pw);
	if(strcmp(name,"admin") == 0 && strcmp(pw,"123") ==0){
		printf("Login successfully!!!");
	}else{
		printf("Login failed");
	}
    return 0;
}

