#ifdef _MSC_VER
#define _CRT_SECURE_NO_WARNINGS
#endif

#include <stdio.h>

int main() {
	int n;

	do
	{
		printf( "0을 입력하세요. ");
		scanf("%d", &n);
	} while (n != 0);

	printf(" 0을 입력하셨습니다. ");
}

