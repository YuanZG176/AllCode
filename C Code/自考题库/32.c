//32、以下程序段的功能是给数组所有的元素输入数据，则应在程序横线填上的选项是___________。
//#include<stdio．h>
//main()
//{int a[10]，i=0；
//while(i<10)scanf("％d",____)；}
//A、a[i++]
//B、&a[i+1]
//C、a+i
//D、&a[++i]
//正确答案：A



#include <stdio.h>
main() {
    int a[10], i = 0;
    while (i < 10)
        scanf("%d", a[i++]);  // 需要填入的选项
}
