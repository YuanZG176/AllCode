//44������������������___________��
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
//A��a
//B��A
//C��B
//D����ȷ����ֵ
//��ȷ�𰸣�B





#include<stdio.h>
void main()
{
    int i, j, k;
    char str[5];
    for(i = 0; i < 5; i++) str[i] = 'A';  // ��ʼ��str���飬����Ԫ�ض�����Ϊ�ַ�'A'
    k = 4;
    for(i = 0; i < k; i++)
        for(j = 0; j < k; j++)
            str[j] = str[i] + 32;  // ��str[j]����Ϊstr[i]����32�����Ӵ�д��ĸת����Сд��ĸ��
    printf("%c\n", str[k]);  // ��ӡstr[k]��ֵ
}
