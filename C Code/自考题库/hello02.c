//#include <stdio.h>
//main()
//{ 
//int x, y, z;
//x=y=1;
//z=x++,y++,++y;
//printf("%d,%d,%d\n",x,y,z);//2,3,1
//}



#include <stdio.h>
main()
{ 
    int x, y, z;
    x = y = 1;  // ��ʼ�� x �� y Ϊ 1
    z = x++, y++, ++y;  // ������һ�����ű��ʽ
    printf("%d,%d,%d\n", x, y, z);  // ��ӡ x, y, z ��ֵ
}
