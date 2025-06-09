#include<stdio.h>
#include<stdlib.h>

struct Node {
    int data;
    struct Node* next;
};

struct Node* head = NULL;

struct Node* createNode(int value) {
    struct Node* newNode = (struct Node*)malloc(sizeof(struct Node));
    newNode->data = value;
    newNode->next = NULL;
    return newNode;
}

void insertAtFirst(int value) {
    if(head == NULL) {
        struct Node* newNode = createNode(value);
        head = newNode;
        return;
    }
    struct Node* newNode = createNode(value);
    newNode->next = head;
    head = newNode;
}

void deleteAtFirst() {
    if(head == NULL) {
        printf("Linked List is empty\n");
        return;
    }
    struct Node* temp = head;
    head = head->next;
    free(temp);
}

void insertAtLast(int value) {
    struct Node* newNode = createNode(value);
    if(head == NULL) {
        head = newNode;
        return;
    }
    struct Node* temp = head;
    while(temp->next != NULL) {
        temp = temp->next;
    }
    temp->next = newNode;
}

void deleteAtLast() {
    if(head == NULL) {
        printf("Linked List is empty\n");
    }

    if(head->next == NULL) {
        free(head);
        head = NULL;
        return;
    }

    struct Node* temp = head;
    while(temp->next->next != NULL) {
        temp = temp->next;
    }
    free(temp->next);
    temp->next = NULL;
}

void display() {
    if(head == NULL) {
        printf("Linked is Empty\n");
        return;
    }

    struct Node* temp = head;
    while(temp->next != NULL) {
        printf("%d -> ", temp->data);
        temp = temp->next;
    }
    printf("%d", temp->data);
}
 
int main() {
    int choice, value;

    while (1) {
        printf("\n1. Insert at first\n2. Delete at first\n3. Insert at Last\n4. Delete at Last\n5. Display\n6. Exit\n");
        printf("Enter your choice: ");
        scanf("%d", &choice);

        switch(choice) {
            case 1:
                printf("Enter Value to insert : ");
                scanf("%d", &value);
                insertAtFirst(value);
                break;
            case 2:
                deleteAtFirst();
                break;
            case 3:
                printf("Enter Value to insert : ");
                scanf("%d", &value);
                insertAtLast(value);
                break;
            case 4:
                deleteAtLast();
                break;
            case 5:
                display();
                break;
            case 6:
                printf("Exiting\n");
                return 0;
        }
    }   
    return 0;
}