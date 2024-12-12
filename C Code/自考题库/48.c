//48、有如下程序段：
//	char str[14]={"Iam"};
//	strcat(str,"sad!");
//	scanf("%s",str);
//	print f("%s",str);
//	当输入为happy！<CR>时，输出的结果是（）。
//A、Iamsad!
//B、happy!
//C、Iamhappy!
//D、happy!ad!
//正确答案：B




#include<stdio.h>
void main()
{
	char str[14]={"Iam"};
	strcat(str,"sad!");
	scanf("%s",str);
	printf("%s",str);
}

