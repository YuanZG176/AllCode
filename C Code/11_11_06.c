#include <stdio.h>

int main(){
	
	int day;
	scanf("%d",&day);
	switch(day){
		case 1:
			printf("Monday");
			break;
		case 2:
			printf("Thusday");
			break;
		case 3:
			printf("Wednesday");
			break;
		case 4:
			printf("Thirsday");
			break;
		default:
			printf("Friday");
			break;
	}
	
	return 0;
}
