#include<stdio.h>

#define STACK_SIZE 100
int top = -1;

void push(int stack[], int value) {
    if(top == -1) {
        top = 0;
        stack[top] = value;
    } else if(top < STACK_SIZE - 1) {
        top++;
        stack[top] = value;
    } else {
        printf("Stack overflow\n");
    }
}

void pop(int stack[]) {
    if(top == -1) {
        printf("Stack Overflow\n");
        return;
    }
    if(top == 0) {
        top = -1;
    } else {
        printf("Popped element is %d\n", stack[top]);
        stack[top] = 0;
        top--;
    }
}

void peek(int stack[]) {
    if(top == -1) {
        printf("Stack is empty\n");
    }
    else {
        printf("Top element is %d\n", stack[top]);
    }
}

void display(int stack[]) {
    int i;
    if(top == -1) {
        printf("Stack is empty\n");
        return;
    }
    for(i = top; i >= 0; i--) {
        printf("%d\n", stack[i]);
    }
}

int main() {
    int stack[STACK_SIZE];
    int choice;

    while(1) {
        printf("\n1. Push\n2. Pop\n3. Peek\n4. Display\n5. Exit\n");
        printf("Enter your choice: ");
        scanf("%d", &choice);
        switch (choice) {
            case 1: {
                int value;
                printf("Enter value to push: ");
                scanf("%d", &value);
                push(stack, value);
                break;
            }
            case 2:
                pop(stack);
                break;
            case 3:
                peek(stack);
                break;
            case 4:
                display(stack);
                break;
            case 5:
                printf("Exiting...\n");
                return 0;
        }
    } 
    
    return 0;
}