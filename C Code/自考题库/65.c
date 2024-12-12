//65、设有如下程序：
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
//	若执行是从键盘上输入的数据时AB，则输出是___________。
//A、AB
//B、ABAA
//C、BBBAABBBAABA
//D、BBBA
//正确答案：B




#include <stdio.h>

int main() {
    char ch1, ch2;
    scanf("%c%c", &ch1, &ch2);
    if (ch1 != 'B') {
        switch (ch2) {
            case 'B':
                switch (ch1) {
                    case 'A': printf("AB"); break;
                    case 'B': printf("BB"); break; // 这个case实际上不会被执行
                }
                // 注意这里没有break语句，所以会继续执行下一个case
            case 'A':
                switch (ch1) {
                    case 'A': printf("AA"); break;
                    case 'B': printf("BA"); break; // 这个case实际上不会被执行
                }
        }
    }
    return 0;
}
