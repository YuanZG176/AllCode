#include <stdio.h>

int main() {
    char string[81]; // Define a character array to store the input string
    int i, num = 0, word = 0; // Initialize variables: i for loop, num for word count, word for tracking words
    char c; // Variable to store each character from the string

    gets(string); // Read a string from the user and store it in 'string'

    // Loop through each character in the string
    for (i = 0; (c = string[i]) != '\0'; i++) {
        if (c == ' ') // If the character is a space
            word = 0; // Reset the word counter
        else if (word == 0) // If the character is not a space and word counter is 0
        {
            word = 1; // Start counting a new word
            num++; // Increment the word count
        }
    }

    printf("There are %d words in this line.\n", num); // Print the number of words
    return 0;
}
