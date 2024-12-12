#include <stdio.h>



//编写一个程序，接收用户输入的一维数组的长度和数组元素，再输入一个目标值，
//查找该值是否在数组中，并输出其索引（如果存在），否则输出“未找到”。
int main(){
	int a[100],k,f;
	int n;
	printf("请输入元素个数：");
	scanf("%d",&n);
	printf("请输入所有元素："); 
	int i;
	for(i = 0;i<n;i++){
		scanf("%d",&a[i]);
	} 
	printf("请输入你要查找元素：");
	scanf("%d",&k);
	f=0;
	for(i=0;i<n;i++){
		if(a[i] == k){
			printf("%d是数组a的第%d个元素.",k,i+1);
			f=1;
			break;
		}
	}
	if(f==0)printf("%d不存在",k);
    return 0;
}

