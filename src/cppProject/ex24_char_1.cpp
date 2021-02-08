#ifdef _MSC_VER
#define _CRT_SECURE_NO_WARNINGS
#endif 

#include <stdio.h>
#include <string.h>


int main() {


	// char str[100];
	// int len;
	 
	char str1[] = "Hello";
	char str2[100];

	strcpy(str2, str1);

	printf(" str2의 값 : %s\n ", str2);

	// scanf("%s", str);
	// len = strlen(str);
	// 
	// 
	// printf("str은 %s, 길이는 %d\n", str, len);

	



}
