#ifdef _MSC_VER
#define _CRT_SECURE_NO_WARNINGS
#endif	

#include <stdio.h>


#pragma region + for Test1

// int main() {
// 	int n;
// 	int sum = 0;
// 
// 	scanf("%d", &n);
// 
// 	for (int i = 1; i <= n; i *= 2)
// 	{
// 		sum += i;
// 		printf("%d\n", i);
// 	}
// 
// 	printf("\n");
// 	printf("%d\n", sum);
// 
// }

#pragma endregion

#pragma region + for Test2

// int main() {
// 
// 	int n;
// 
// 	scanf("%d", &n);
// 
// 	printf("\n");
// 	for (int i = 0; i <= n; i++)
// 	{
// 		printf("**");
// 	}
// 	printf("\n");
// }

#pragma endregion


#pragma region + for Test3

int main() {
	int n;

	scanf("%d", &n);

	for (int i = 2; i <= n; i++)
	{
		for (int j = 1; j <= 9; j++)
		{
			printf("%d * %d = %d \n", i, j, i * j);
		}
		printf("\n");
	}

	printf("\n");

}

#pragma endregion
