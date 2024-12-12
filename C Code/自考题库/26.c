//26、若执行下面的程序时从键盘上输入10,则输出是___________。
//main()
//{int a；scanf("％d"，&a)；
//if(a++>10)
//print f("％d\n"，++a)；
//else print f("％d\n"，a--)；}
//A、12
//B、11
//C、10
//D、9
//正确答案：B




#include <stdio.h>

main()
{
    int a;
    scanf("%d", &a);  // 从键盘输入一个整数并存储在变量 a 中
    if (a++ > 10) {   // 检查 a 是否大于 10
        printf("%d\n", ++a);  // 如果条件为真，先自增 a，然后打印 a
    } else {
        printf("%d\n", a--);  // 如果条件为假，先打印 a，然后自减 a
    }
}
