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
    x = y = 1;  // 初始化 x 和 y 为 1
    z = x++, y++, ++y;  // 这里是一个逗号表达式
    printf("%d,%d,%d\n", x, y, z);  // 打印 x, y, z 的值
}
