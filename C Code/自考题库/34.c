//34����֪a,b,c��ֵ�ֱ���1��2��3����ִ����������a,b,c��ֵ�ֱ���___________��
//if(a++<b){c=a;a=b;b=c;}
//else  a=b=c=0;
//A��0��0��0
//B��1��2��3
//C��1��2��1
//D��2��2��2
//��ȷ�𰸣�D


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
