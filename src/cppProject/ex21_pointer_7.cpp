#ifdef _MSC_VER
#define _CRT_SECURE_NO_WARINGS
#endif 

#include <stdio.h>

int main() 
{
	/*
	
	포인터 배열
		- 포인터의 배열
		- 포인터 형식의 배열
		- 포인터가 배열로 있는 것을 포인터 배열
		- 주소값들을 저장하는 배열
	

		int* arr1[5]        크기가 5인 int* 배열
		char* arr2[10]		크기가 10인 char* 배열
		double* arr1[4]		크기가 4인 double* 배열


	배열 포인터
		- 배열을 가리키는 포인터
		- 배열의 시작주소값을 저장할 수 잇는 포인터
		int (*ptr)[4] -> 4개짜리 int 형 배열을 가리키는 포인터

	*/

#pragma region + 포인터 배열

	int a = 100, b = 500, c = 2300;

	int* data[] = { &a, &b, &c };


	for (int i = 0; i <= 2; i++)
	{
		printf(" 1data %d  ", *data[i]);
		printf("\n");
	}
	printf("\n");

	for (int i = 0; i <= 2; i++)
	{
		printf(" 2data %d ", &data[i]);
		printf("\n");
	}
	printf("\n");

	for (int i = 0; i <= 2; i++)
	{
		printf(" 3data %d ", data[i]);
		printf("\n");
	}

#pragma endregion

	int numArr[10] = { 11, 22, 33, 44, 55, 66, 77, 88, 99, 110 };

	int* numPtr = numArr;

	printf(" *numPtr %d\n", *numPtr);
	printf(" *numArr %d\n", *numArr);
	printf(" numPtr %d\n", numPtr[5]);
	printf(" numPtr %d\n", sizeof(numPtr));
	printf(" numArr %d\n", sizeof(numArr));


	int array3[2][4] = { 1,2,3,4,5,6,7,8 };
	int(*array2)[4] = array3;

	for (int i = 0; i < 2; i++) {
		for (int j = 0; j < 4; j++)
		{
			printf("%d ", array2[i][j]);
		}
	}


	int aa[5] = {1,2,3,4,5};
	int(*pa)[5];
	int i;
	printf("\n");	
	printf("\n");
	pa = &aa;
	for (i = 0; i < 5; i++)
	{
		printf("(*pa)[i] %d \n", (*pa)[i]);
		printf("pa[i] %d \n", pa[i]);
		printf("&pa[i] %d \n", &pa[i]);
	}





}