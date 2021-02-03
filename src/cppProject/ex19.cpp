#ifdef _MSC_VER
#define _CRT_SECURE_NO_WARNINGS
#endif

#include <stdio.h>
#include <string.h>

int main() {
	char arr[] = "Hello, world";
	char str[100] = "Hello";

	// printf("%s\n", arr);
	
	printf("배열의 크기 : %d\n ", sizeof(arr) / sizeof(char));

	char str1[] = "Hello";
	char str2[100];

	// 헤더파일 <string.h>   C++에서는 <cstring>
	strcpy(str2, str1);
	// st1에 있는 문자열을 str2로 복사하는 함수
	printf("str2 : %s\n ", str2);

	// strcat 문자열 연결!
	strcat(str, "World!");
	strcat(str, "World!");
	strcat(str, "World!");
	strcat(str, "World!");
	strcat(str, "World!");

	printf("%s\n", str);






}