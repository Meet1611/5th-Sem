#include<stdio.h>

#define QUEUE_SIZE 100
int front = -1, rear = -1;

void enqueue(int queue[], int value) {
    if(rear == -1) {
        front = 0;
        rear = 0;
        queue[rear] = value;
    }
    else if(rear < QUEUE_SIZE - 1) {
        queue[++rear] = value;
    }
    else {
        printf("Queue Overflow\n");
    }
}

void dequeue(int queue[]) {
    if(front == -1 || front > rear) {
        printf("Queue Underflow\n");
        return;
    }
    printf("Dequeued element is %d\n", queue[front]);
    if(front == rear) {
        front = -1;
        rear = -1;
    } else {
        front++;
    }
}

void display(int queue[]) {
    if(front == -1 || front > rear) {
        printf("Queue is empty\n");
        return;
    }
    int i;
    for(i = front; i <= rear; i++) {
        printf("%d\n", queue[i]);
    }
}

int main() {
    int queue[QUEUE_SIZE];
    int choice, value;

    while (1)
    {
        printf("\n1. Enequeue\n2. Dequeue\n3. Display\n4. Exit\n");
        printf("Enter your choice: ");
        scanf("%d", &choice);

        switch(choice) {
            case 1:
                printf("Enter Value to enqueue : ");
                scanf("%d", &value);
                enqueue(queue,value);
                break;
            case 2:
                dequeue(queue);
                break;
            case 3:
                display(queue);
                break;
            case 4:
                printf("Exiting...\n");
                return 0;
        }
    }
    return 0;
}