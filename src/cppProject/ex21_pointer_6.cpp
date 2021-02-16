#ifdef _MSC_VER
#define _CRT_SECURE_NO_WARINGS
#endif 

#include <stdio.h>

int main()
{
	int test = 21;
	int *pointer = &test;

	printf("\n");
	printf("	test -> %d\n", test);
	//printf("*test -> %d\n", *test);
	printf("	&test -> %d\n", &test);

	printf("	pointer -> %d\n", pointer);
	printf("	*pointer -> %d\n", *pointer);
	printf("	&pointer -> %d\n", &pointer);
	printf("\n");

	
	printf("	pointer 주소값 : %d\n", pointer);
	printf("	&test 주소값 : %d\n", &test);
	
	printf("\n");

	printf("	*pointer 값 : %d\n", *pointer);
	printf("	test 값 : %d\n", test);
	
	


	
	/*
	int arr[2][3] = { {1,2,3},{4,5,6} };
	
	int(*ptr)[3] = arr;


	for (int i = 0; i < 2 ; i++)
	{
		for (int j = 0; j < 3; j++)
		{
			printf("%d ", ptr[i][j]);
		}
		printf("\n");
	}

	printf("\n");


	for (int(*row)[3] = arr; row < arr+2; row++)
	{
		for (int *col = *row; col < *row+3; col++)
		{
			printf("%d ", *col);
		}
		printf("\n");
	}
	*/






	// printf("%d\n", sizeof(arr));
	// printf("%d\n", sizeof(arr[0]));
	// printf("%d\n", sizeof(arr[0][0]));
	// 
	// printf("%d\n", &arr);
	// printf("%d\n", &arr[0]);
	// printf("%d\n", &arr[0][0]);

}


