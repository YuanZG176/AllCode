#include <stdio.h>

int main() {
	int i,j,row=0,colom=0; 

	int a[3][4] = {{1, 2, 3, 4}, {9, 8, 7, 6}, {-10, 10, -5, 2}}; // �������鲢����ֵ
	int max = a[0][0]; // ����Ϊ a[0][0]���
	for (i = 0; i <= 2; i++) // �����������
	    for (j = 0; j <= 3; j++) // �����������
	        if (a[i][j] > max) // ���ĳԪ�ش��� max, ��ȡ�� max ��ԭֵ
	            {
	                max = a[i][j]; // ���´�Ԫ�ص�ֵ
	                row = i; // ���´�Ԫ�ص��к�
	                colom = j; // ���´�Ԫ�ص��к�
	            }
	printf("max = %d\nrow = %d\ncolom = %d\n", max, row, colom); // ������ֵ����λ��
	return 0;


}
