#include <stdio.h>
//this is a comment
/*this is another comment*/
int main(){
    //following are print statements
    printf("hello wrold!\n");
    printf("this is the 2nd line\n\n");

    //datatype varName = value;
    int myNum = 10;
    // Declare a variable
    int myNum1;
    // Assign a value to the variable
    myNum1 = 15;

    //Format Specifiers
    //{int: [%d , %i], char: %c, float: %f}
    printf("%d\n", myNum1);

    // Create variables
    myNum = 10;                 // Integer (whole number)
    float myFloatNum = 5.99;    // Floating point number
    char myLetter = 'D';        // Character

    // Print variables
    printf("%d\n", myNum);
    printf("%f\n", myFloatNum);
    printf("%c\n", myLetter);
    printf("My number is %d and my letter is %c\n\n\n", myNum, myLetter);
    //printf("the number is %d and the letter is %c and another one is %c %c\n", 10, myLetter);

    // Student data
    int studentID = 15;
    int studentAge = 23;
    float studentFee = 75.25;
    char studentGrade = 'B';

    // Print variables
    printf("Student id: %d\n", studentID);
    printf("Student age: %d\n", studentAge);
    printf("Student fee: %f\n", studentFee);
    printf("Student grade: %c", studentGrade);

    return 0;
}