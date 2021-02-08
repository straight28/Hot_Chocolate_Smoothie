#ifdef _MSC_VER
#define _CRT_SECURE_NO_WARNINGS
#endif 


#pragma region + 입력 받은 숫자들을 거꾸로 출력

// #include <stdio.h>
// 
// int main()
// {
// 	int n;
// 	int arr[1000];
// 
// 	printf(" 입력할 숫자의 개수 입력 : ");
// 	scanf("%d", &n);
// 
// 	for (int i = 0; i < n; i++)
// 	{
// 		scanf("%d", &arr[i]);
// 	}
// 
// 	for (int i = n - 1; 0 <= i; i--)
// 	{
// 		printf("%d / ", arr[i]);
// 	}
// 
// 	return 0;
// }


#pragma endregion

#pragma region + 최대, 최소

//#include <stdio.h>
//
// int main() {
// 
// 	int n;
// 	int arr[100];
// 
// 	scanf("%d", &n);
// 
// 	for (int i = 0; i < n; i++)
// 	{
// 		scanf("%d", &arr[i]);
// 	}
// 
// 	int max = arr[0];
// 	int min = arr[0];
// 
// 	for (int i = n - 1; 0 <= i; i--)
// 	{
// 		if (max < arr[i]) {
// 			max = arr[i];
// 		}
// 
// 		if (min > arr[i]) {
// 			min = arr[i];
// 		}
// 	}
// 
// 	printf("\n");
// 	printf("최대값은 %d \n", max);
// 	printf("최소값은 %d \n", min);
// 
// 	return 0;
// }


#pragma endregion

#pragma region + 짝수의 수

#include <stdio.h>

int main() {

	int n;
	int arr[100];
	int even = 0;

	scanf("%d", &n);

	for (int i = 0; i < n; i++)
	{
		scanf("%d", &arr[i]);
	}


	for (int i = 0; i < n; i++)
	{
		if (arr[i] % 2 == 0) {
			even++;
		}
	}

	printf("짝수의 수는 %d", even);

	return 0;
}

#pragma endregion











