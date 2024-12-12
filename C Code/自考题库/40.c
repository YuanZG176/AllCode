//40、以下if语句中格式正确的是___________。
//A、if(a>b)b++else a++；
//B、if(a>b){b++；print f("％d"，b)；}
//else {a++；print f("％d"，a)；}
//C、if(a>b){b++；print f("％d"，b)}
//else {a++；print f("％d"，a)；}
//D、if(a>b)b++；print f("％d"，b)；
//else print f("％d"，a)；
//正确答案：B


#include <stdio.h>

main() {
	int a = 2,b= 3;
	
	
//if(a>b)b++;else{
//a++;} 
//printf("%d %d\n",a,b);





if(a>b){b++;printf("%d",b);}
else {a++;printf("%d",a);}




//if(a>b){b++;printf("%d",b);}
//else {a++;printf("%d",a);} 
//但是在printf函数调用之后缺少了一个分号（;）



//
//if(a>b){
//	b++;printf("%d",b);
//}
//else printf("%d",a);


//printf("%d %d\n",a,b);
}
