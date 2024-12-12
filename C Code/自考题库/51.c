//#include<stdio．h>．
//main()
//{int al=0，a2=0，a3=0；
//char ch；
//while((ch=getchar ())!='\n')
//switch(ch)
//{case'A'：a1++；
//case'B'：a2++；
//default：a3++；}
//print f("％d，％d，％d"，a1，a2，a3)；}




//代码中switch语句的每个case分支后没有使用break;语句。这意味着如果匹配到'A'，
//则会执行a1++，然后继续执行a2++和a3++；如果匹配到'B'，则会执行a2++，然后继续执行default部分的a3++。
//default部分总是会被执行，除非遇到'\n'结束循环。


#include <stdio.h>

int main() {
    int a1 = 0, a2 = 0, a3 = 0;
    char ch;

    while ((ch = getchar()) != '\n') {
        switch (ch) {
            case 'A':
                a1++;
                //break; // 防止连续执行下一个case
            case 'B':
                a2++;
                //break; // 同上
            default: // 对于不是'A'也不是'B'的字符
                a3++;
                //break; // 结束当前switch语句
        }
    }

    printf("%d, %d, %d\n", a1, a2, a3); // 输出结果，使用英文逗号分隔

    return 0; // 主函数返回0表示程序正常结束
}

