//#include<stdio£®h>
//main()
//{
//int x£¬y£»print f("Enter an int eger(x)£º")£»
//scanf("£¥d"£¬&x)£»
//if(x++<0)y=-1£»
//else if(x==0)y=0£»else y=1£»print f("£¥d",y); 
//}




#include <stdio.h>

int main() {
    int x, y;
    printf("Enter an integer (x): ");
    scanf("%d", &x);

    if (x++ < 0) {
        y = -1;
    } else if (x == 0) {
        y = 0;
    } else {
        y = 1;
    }

    printf("%d\n", y);

    return 0;
}
