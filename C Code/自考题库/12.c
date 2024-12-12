//当执行程序时，按下列方式输入数据（从第 1列开始，<CR>代表回车，注意：回车也是一个字符）
//12<CR>
//34<CR>
//则输出结果是___________。



#include <stdio.h>
main()
{ 
char a,b,c,d;
scanf("%c%c",&a, &b);
c=getchar(); d=getchar();
printf("%c%c%c%c\n",a,b,c,d);
}



