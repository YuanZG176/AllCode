//38�����³������������___________��
//	#include<stdio.h>
//	#include<string.h>
//	void  main()
//	{
//		char st[20]="hello\0\t\\";
//		print f("%d%d\n",strlen(st),sizeof
//
//(st));
//}
//A��99
//B��520
//C��1320
//D��2020
//��ȷ�𰸣�B




#include <stdio.h>
#include <string.h>

void main() {
    char st[20] = "hello\0\t\\";
    printf("%d %d\n", strlen(st), sizeof(st));
}
