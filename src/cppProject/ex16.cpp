#ifdef _MSC_VER
#define _CRT_SECURE_NO_WARNINGS
#endif 

#include <stdio.h>

int main() {
	int a[10];
	int arr[5] = { 3, 1, 4, 1, 5};
	int arrr[] = { 3, 1, 4, 1, 5, 3, 1, 4, 1, 5 };


	for (int i = 0; i < 10; i++)
	{
		a[i] = i * 50;
	}

	for (int i = 0; i < 10 ; i++)
	{
		printf("%d . ", a[i]);
	}

	printf("\n");

	for (int i = 0; i < 5; i++)
	{
		printf("%d . ", arr[i]);
	}

	printf("\n");

	for (int i = 0; i < sizeof(arrr) / sizeof(int); i++)
	{
		printf("%d . ", arrr[i]);
	}
	printf("\n");
	

}


