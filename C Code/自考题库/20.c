//20�������г���Σ�
//char ch;
//int s=0;
//for(ch='A';ch<'Z';++ch)
//if(ch%2==0)s++;
//	print f("%d",s);
//	��ִ������Ƭ�κ󣬳������������___________��
//A��13
//B��12
//C��26
//D��25
//��ȷ�𰸣�A


#include <stdio.h>

int main() {
    char ch;
    int s = 0;
    for (ch = 'A'; ch <= 'Z'; ++ch) {  // ע�⣺����Ӧ���� ch <= 'Z'
        if (ch % 2 == 0) {
            s++;
        }
    }
    printf("%d\n", s);  // ע�⣺printf �ĸ�ʽ�ַ���         �ַ� 'A' �� 'Z' �� ASCII ��ֱ��� 65 �� 90��

    return 0;
}

