//57���������
//	#include<stdio��h>
//main()
//{int a,b;
//	for(a=1,b=1;a<=100;a++)
//	{if(b>=20)break;
//	if(b%3==1){b+=3;continue;}
//	b=-5;}
//	print f("%d\n",a);}
//	����������������___________��
//A��7
//B��8
//C��9
//D��10
//��ȷ�𰸣�B






//	#include <stdio.h>
//main()
//{int a,b;
//	for(a=1,b=1;a<=100;a++)
//	{if(b>=20)break;
//	if(b%3==1){b+=3;continue;}
//	b=-5;}
//	printf("%d\n",a);}
	
	
	
	
#include <stdio.h>
main()
{
    int a, b;
    for(a = 1, b = 1; a <= 100; a++)
    {
        if(b >= 20) break;
        if(b % 3 == 1)
        {
            b += 3;
            continue;
        }
        b = -5;
    }
    printf("%d\n", a);
}
