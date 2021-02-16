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

	printf("a의 주소 &a[0]= %p, a= %p \n", &a[0], a);
	printf("a의 값 : %d\n", *a);

	for (i = 0; i < 5; i++)
	{
		printf("\t 주소 %p a[%d] : %d, *(a+%d) : %d\n", (a+i), i, a[i], i, *(a+i));
	}
	printf("\n");

	printf("ptr이 가리키는 주소 : %p\n", ptr);

	for (i = 0; i < 5; i++)
	{
		printf("\t 주소 %p ptr[%d] : %d, *(ptr+%d) : %d\n", (ptr + i), i, ptr[i], i, *(ptr + i));
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
	3. ptr + 1 == ptr에 sizeof(*ptr)을 더한 값


*/



