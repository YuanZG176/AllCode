//#include<stdio.h>
//main()
//{
//int x=l,y=0,a=0,b=0;
//switch(x)
//{casel��
//switch(y)
//{case0:a++;break;
//case1��b++��break��}
//case2��
//a++��b++;break��}
//printf("a=��d,b=��d\n",a,b);
//}



#include <stdio.h>
main()
{
    int x=1, y=0, a=0, b=0;  // ע�⣺x �ĳ�ʼֵ�� 1������ l
    switch(x)
    {
        case 1:  // ע�⣺case ����û�зֺ�
            switch(y)
            {
                case 0:
                    a++;  // �� y Ϊ 0 ʱ��a ����
                    break;
                case 1:
                    b++;  // �� y Ϊ 1 ʱ��b ����
                    break;
            }
            // ע������û�� break ��䣬���Ի����ִ�� case 2 �Ĵ���
        case 2:
            a++;  // a �ٴ�����
            b++;  // b ����
            break;  // �˳� switch ���
    }
    printf("a=%d, b=%d\n", a, b);  // ��ӡ a �� b ��ֵ  a=2, b=1
}
