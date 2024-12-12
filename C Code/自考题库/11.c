#include<stdio.h>
main()
{
int sum,pad,pAd;
sum=pad=5;
pAd=++sum,pAd++,++pad;
printf("%d\n",pad);//6
}

