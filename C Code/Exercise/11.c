#include <stdio.h>

typedef struct{
	char name[50];
	float score;
	int gender;
	int age;
} Student;

int main(){
	Student s1,s2;
	strcpy(s1.name,"tom");
	s1.score = 90;
	s1.gender=1;
	s1.age  =12;
	printf("%d %s %f %s",s1.age,s1.gender?"male":"female",s1.score,s1.name);
    return 0;
}

