//#include<stdio��h>��
//main()
//{int al=0��a2=0��a3=0��
//char ch��
//while((ch=getchar ())!='\n')
//switch(ch)
//{case'A'��a1++��
//case'B'��a2++��
//default��a3++��}
//print f("��d����d����d"��a1��a2��a3)��}




//������switch����ÿ��case��֧��û��ʹ��break;��䡣����ζ�����ƥ�䵽'A'��
//���ִ��a1++��Ȼ�����ִ��a2++��a3++�����ƥ�䵽'B'�����ִ��a2++��Ȼ�����ִ��default���ֵ�a3++��
//default�������ǻᱻִ�У���������'\n'����ѭ����


#include <stdio.h>

int main() {
    int a1 = 0, a2 = 0, a3 = 0;
    char ch;

    while ((ch = getchar()) != '\n') {
        switch (ch) {
            case 'A':
                a1++;
                //break; // ��ֹ����ִ����һ��case
            case 'B':
                a2++;
                //break; // ͬ��
            default: // ���ڲ���'A'Ҳ����'B'���ַ�
                a3++;
                //break; // ������ǰswitch���
        }
    }

    printf("%d, %d, %d\n", a1, a2, a3); // ��������ʹ��Ӣ�Ķ��ŷָ�

    return 0; // ����������0��ʾ������������
}

