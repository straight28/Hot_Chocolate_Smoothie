#ifdef _MSC_VER
#define _CRT_SECURE_NO_WARNINGS
#endif // _MSC_VER

#include <stdio.h>

int main() 
{

	/*
	
	포인터를 배열처럼 사용하기 위해서 배열 포인터를 정의하여 사용한다.
	배열 포인터는 1차원 배열에서는 아무런 의미가 없으며, 2차원 이상의 배열에서만 의미를 가진다.
	
	*/

	int i, arr_len;

	int num01 = 10, num02 = 20, num03 = 30;
	int* arr[3] = { &num01, &num02, &num03 }; // int형 포인터 배열 선언

	arr_len = sizeof(arr) / sizeof(arr[0]);

	for (i = 0; i < arr_len; i++)
	{
		printf("%d\n", *arr[i]);
	}
}

/*

포인터 배열과 배열 포인터의 구분

int (*pArr)[3]; --> int형 데이터를 저장할 수 있는 
					2차원 배열을 가리치는 배열 포인터

int* pArr[3]; --> int형 데이터를 가리킬 수 있는 
				  포인터 변수를 모아 놓은 배열을
				  가리치는 포인터 배열

따라서 괄호의 유무가 중요하고, 포인터 배열과 배열 포인터 사이의 차이점을 정확히 이해하고 넘어가야 한다.

*/
