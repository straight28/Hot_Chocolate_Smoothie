#ifdef _MSC_VER
#define _CRT_SECURE_NO_WARNINGS
#endif

#include <stdio.h>


int main() {

	int n;

	scanf("%d", &n);

	//for (int i = 1; i <= n ; i++)
	//{
	//	for (int j = 1; j <= 2 * i - 1; j+= 2)
	//	{
	//		printf("%d ", 2 * j - 1);
	//	}
	//	printf("\n");
	//}

	for (int i = 1; i <= n; i++)
	{
		for (int j = 1; j <= 2 * i - 1; j += 2)
		{
			printf("%d ", 2 * j - 1);
		}

		printf("\n");
	}

	printf("\n");

	for (int i = 1; i <= 2 * n - 1; i+=2)
	{
		for (int j = 1; j <=i; j ++)
		{
			printf("%d ", j);
		}

		printf("\n");
	}



}

