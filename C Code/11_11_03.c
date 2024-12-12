#include <stdio.h>


int main() {
    char ch;
    
    printf("ÇëÊäÈëÒ»¸ö×Ö·û: ");
    scanf("%c", &ch);
    if (ch >= 'A' && ch <= 'Z') {
        printf("´óÐ´×ÖÄ¸\n");
    } else if (ch >= 'a' && ch <= 'z') {
        printf("Ð¡Ð´×ÖÄ¸\n");
    } else if (ch >= '0' && ch <= '9') {
        printf("Êý×Ö\n");
    } else {
        printf("ÆäËû·ûºÅ\n");
    }
    
    return 0;
}

