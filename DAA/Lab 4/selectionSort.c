#include<stdio.h>
#include<time.h>

int readArrayFromFile(char *filename, int arr[], int n) {
    FILE *f = fopen(filename, "r");
    if (f == NULL) {
        printf("Could not open file %s\n", filename);
        return 0;
    }
    for(int i = 0; i < n; i++) {
        fscanf(f, "%d ", &arr[i]);
    }
    fclose(f);
    return 1;
}

#define N1 100
#define N2 1000
#define N3 10000
#define N4 100000

void selectionSort(int arr[], int n){
    for(int i = 0; i < n - 1; i++){
        int min = i;
        for(int j = i + 1; j < n; j++){
            if(arr[min] > arr[j]){
                min = j;
            }
        }
        if(min != i){
            int temp = arr[i];
            arr[i] = arr[min];
            arr[min] = temp;
        }
    }    
}

int main() {
    int arr1[N1];
    int arr2[N2];
    int arr3[N3];
    int arr4[N4];

    clock_t start, end;
    double time_taken;

    if(readArrayFromFile("./../Arrays/best_case_100.txt", arr1, N1)) {
        start = clock();
        selectionSort(arr1, N1);
        end = clock();
        time_taken = ((double)(end - start)) / CLOCKS_PER_SEC * 1000;
        printf("Time Taken by algo (best case 100) : %lf\n", time_taken);
    }

    if(readArrayFromFile("./../Arrays/worst_case_100.txt", arr1, N1)) {
        start = clock();
        selectionSort(arr1, N1);
        end = clock();
        time_taken = ((double)(end - start)) / CLOCKS_PER_SEC * 1000;
        printf("Time Taken by algo (worst case 100) : %lf\n", time_taken);
    }

    if(readArrayFromFile("./../Arrays/average_case_100.txt", arr1, N1)) {
        start = clock();
        selectionSort(arr1, N1);
        end = clock();
        time_taken = ((double)(end - start)) / CLOCKS_PER_SEC * 1000;
        printf("Time Taken by algo (average case 100) : %lf\n", time_taken);
    }

    if(readArrayFromFile("./../Arrays/best_case_1000.txt", arr2, N2)) {
        start = clock();
        selectionSort(arr2, N2);
        end = clock();
        time_taken = ((double)(end - start)) / CLOCKS_PER_SEC * 1000;
        printf("Time Taken by algo (best case 1000) : %lf\n", time_taken);
    }

    if(readArrayFromFile("./../Arrays/worst_case_1000.txt", arr2, N2)) {
        start = clock();
        selectionSort(arr2, N2);
        end = clock();
        time_taken = ((double)(end - start)) / CLOCKS_PER_SEC * 1000;
        printf("Time Taken by algo (worst case 1000) : %lf\n", time_taken);
    }

    if(readArrayFromFile("./../Arrays/average_case_1000.txt", arr2, N2)) {
        start = clock();
        selectionSort(arr2, N2);
        end = clock();
        time_taken = ((double)(end - start)) / CLOCKS_PER_SEC * 1000;
        printf("Time Taken by algo (average case 1000) : %lf\n", time_taken);
    }

    if(readArrayFromFile("./../Arrays/best_case_10000.txt", arr3, N3)) {
        start = clock();
        selectionSort(arr3, N3);
        end = clock();
        time_taken = ((double)(end - start)) / CLOCKS_PER_SEC * 1000;
        printf("Time Taken by algo (best case 10000) : %lf\n", time_taken);
    }

    if(readArrayFromFile("./../Arrays/worst_case_10000.txt", arr3, N3)) {
        start = clock();
        selectionSort(arr3, N3);
        end = clock();
        time_taken = ((double)(end - start)) / CLOCKS_PER_SEC * 1000;
        printf("Time Taken by algo (worst case 10000) : %lf\n", time_taken);
    }

    if(readArrayFromFile("./../Arrays/average_case_10000.txt", arr3, N3)) {
        start = clock();
        selectionSort(arr3, N3);
        end = clock();
        time_taken = ((double)(end - start)) / CLOCKS_PER_SEC * 1000;
        printf("Time Taken by algo (average case 10000) : %lf\n", time_taken);
    }

    if(readArrayFromFile("./../Arrays/best_case_100000.txt", arr4, N4)) {
        start = clock();
        selectionSort(arr4, N4);
        end = clock();
        time_taken = ((double)(end - start)) / CLOCKS_PER_SEC * 1000;
        printf("Time Taken by algo (best case 100000) : %lf\n", time_taken);
    }

    if(readArrayFromFile("./../Arrays/worst_case_100000.txt", arr4, N4)) {
        start = clock();
        selectionSort(arr4, N4);
        end = clock();
        time_taken = ((double)(end - start)) / CLOCKS_PER_SEC * 1000;
        printf("Time Taken by algo (worst case 100000) : %lf\n", time_taken);
    }

    if(readArrayFromFile("./../Arrays/average_case_100000.txt", arr4, N4)) {
        start = clock();
        selectionSort(arr4, N4);
        end = clock();
        time_taken = ((double)(end - start)) / CLOCKS_PER_SEC * 1000;
        printf("Time Taken by algo (average case 100000) : %lf\n", time_taken);
    }
}
