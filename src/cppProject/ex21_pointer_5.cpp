#ifdef _MSC_VER
#define _CRT_SECURE_NO_WARNINGS
#endif 

#include <stdio.h>


int main() 
{
	int arr[3] = { 1,2,3 };
	int* ptr1 = arr;


	int i;
	int a[5] = { 5,3,1,2,4 };
	int* ptr = a;

	printf("a�� �ּ� &a[0]= %p, a= %p \n", &a[0], a);
	printf("a�� �� : %d\n", *a);

	for (i = 0; i < 5; i++)
	{
		printf("\t �ּ� %p a[%d] : %d, *(a+%d) : %d\n", (a+i), i, a[i], i, *(a+i));
	}
	printf("\n");

	printf("ptr�� ����Ű�� �ּ� : %p\n", ptr);

	for (i = 0; i < 5; i++)
	{
		printf("\t �ּ� %p ptr[%d] : %d, *(ptr+%d) : %d\n", (ptr + i), i, ptr[i], i, *(ptr + i));
	}


	printf("=================================================================");
	printf("\n");

	printf("arr = %d\n ", arr);
	printf("arr + 1 = %d\n", arr + 1);
	printf("&arr = %d\n", &arr);
	printf("&arr + 1 = %d\n", &arr + 1);

	for (int i = 0; i < 3; i++)
	{
		printf("%d ", *(ptr1 + i));
	}
	printf("\n");


	for (int i = 0; i < 3; i++)
	{
		printf("%d ", ptr1[i]);
	}
	printf("\n");

	// arr[i] == *(arr + i) == *(ptr + i) == *(i + ptr) == i[ptr]

	for (int i = 0; i < 3; i++)
	{
		printf("%d ", i[ptr1]);
	}
	printf("\n");







}


/*

	1. arr = &arr[0]
	   ptr = &ptr[0]	

    2. *ptr = ptr[0]
	3. ptr + 1 == ptr�� sizeof(*ptr)�� ���� ��


*/



