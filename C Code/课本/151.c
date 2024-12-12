#include <stdio.h>

int main() {
	int i,j,row=0,colom=0; 

	int a[3][4] = {{1, 2, 3, 4}, {9, 8, 7, 6}, {-10, 10, -5, 2}}; // 定义数组并赋初值
	int max = a[0][0]; // 先认为 a[0][0]最大
	for (i = 0; i <= 2; i++) // 遍历数组的行
	    for (j = 0; j <= 3; j++) // 遍历数组的列
	        if (a[i][j] > max) // 如果某元素大于 max, 就取代 max 的原值
	            {
	                max = a[i][j]; // 记下此元素的值
	                row = i; // 记下此元素的行号
	                colom = j; // 记下此元素的列号
	            }
	printf("max = %d\nrow = %d\ncolom = %d\n", max, row, colom); // 输出最大值及其位置
	return 0;


}
