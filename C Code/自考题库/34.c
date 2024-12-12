//34、已知a,b,c的值分别是1，2，3，则执行下列语句后a,b,c的值分别是___________。
//if(a++<b){c=a;a=b;b=c;}
//else  a=b=c=0;
//A、0，0，0
//B、1，2，3
//C、1，2，1
//D、2，2，2
//正确答案：D


#include <stdio.h>
main() {


int a = 1, b = 2, c = 3;
if (a++ < b) {
    c = a;
    a = b;
    b = c;
} else {
    a = b = c = 0;
}


printf("%d %d %d\n",a,b,c);

return 0;
}
