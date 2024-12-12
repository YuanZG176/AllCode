#include <stdio.h>

int main() {
    int a[10], i, j, t;
    printf("input 10 numbers:\n");
    
    // Input 10 numbers
    for (i = 0; i < 10; i++) {
        scanf("%d", &a[i]);
    }
    
    // Bubble Sort algorithm
    for (i = 0; i < 9; i++) {
        for (j = 0; j < 9 - i; j++) {
            if (a[j] > a[j + 1]) {
                t = a[j];
                a[j] = a[j + 1];
                a[j + 1] = t;
            }
        }
    }
    
    // Print the sorted numbers
    printf("the sorted numbers:\n");
    for (i = 0; i < 10; i++) {
        printf("%d ", a[i]);
    }
    printf("\n");
    
    return 0;
}
