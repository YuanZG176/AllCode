//65���������³���
//	#include<stdio.h>
//	main()
//	{char ch1,ch2;
//	scanf("%c%c",&ch1,&ch2);
//	if(ch1!='B')
//{switch(ch2)
//{case'B':
//switch(ch1)
//{case'A':print f("AB")
//break;
//case'B':print f("BB")
//break;}
//case'A':
//switch(ch1)
//{case'A':print f("AA")
//break;
//case'B':print f("BA");
//break;
//}}}}}
//	��ִ���ǴӼ��������������ʱAB���������___________��
//A��AB
//B��ABAA
//C��BBBAABBBAABA
//D��BBBA
//��ȷ�𰸣�B




#include <stdio.h>

int main() {
    char ch1, ch2;
    scanf("%c%c", &ch1, &ch2);
    if (ch1 != 'B') {
        switch (ch2) {
            case 'B':
                switch (ch1) {
                    case 'A': printf("AB"); break;
                    case 'B': printf("BB"); break; // ���caseʵ���ϲ��ᱻִ��
                }
                // ע������û��break��䣬���Ի����ִ����һ��case
            case 'A':
                switch (ch1) {
                    case 'A': printf("AA"); break;
                    case 'B': printf("BA"); break; // ���caseʵ���ϲ��ᱻִ��
                }
        }
    }
    return 0;
}
