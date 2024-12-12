//44、下面程序的输出结果是___________。
//	#include<stdio.h>
//	void main()
//	{
//		int i,j,k;
//		char str[5];
//		for(i=0;i<5;i++)str[i]='A';
//		k=4;
//		for(i=0;i<k;i++)
//			for(j=0;j<k;j++)
//				str[j]=str[i]+32;
//		print f("%c\n",str[k]);
//	}
//A、a
//B、A
//C、B
//D、不确定的值
//正确答案：B





#include<stdio.h>
void main()
{
    int i, j, k;
    char str[5];
    for(i = 0; i < 5; i++) str[i] = 'A';  // 初始化str数组，所有元素都设置为字符'A'
    k = 4;
    for(i = 0; i < k; i++)
        for(j = 0; j < k; j++)
            str[j] = str[i] + 32;  // 将str[j]设置为str[i]加上32（即从大写字母转换成小写字母）
    printf("%c\n", str[k]);  // 打印str[k]的值
}
