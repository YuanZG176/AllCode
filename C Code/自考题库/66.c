//66�������³���
//	#include<stdio.h>
//	#include<string.h>
//	void main()
//	{
//		char a[7]="a0\0a0\0";int i,j;
//		i=sizeof(a);j=strlen(a);
//		print f("%d%d\n",i,j);
//	}
//�����������к����������______��
//A��22
//B��76
//C��72
//D��62
//��ȷ�𰸣�C



	#include<stdio.h>
	#include<string.h>
	void main()
	{
		char a[7]="a0\0a0\0";int i,j;
		i=sizeof(a);j=strlen(a);
		printf("%d%d\n",i,j);
	}
