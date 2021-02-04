#ifdef _MSC_VER
#define _CRT_SECURE_NO_WARNINGS
#endif

#include <stdio.h>

// & : 변수 또는 상수의 주소
// * : 포인터가 가리키는 주소에 저장된(혹은 연결된) 값
// 포인터 : 변수의 주소를 저장하는 변수

int main() {
	/*
	int a = 20;
	int *ptr_a;
	ptr_a = &a;

	
	printf("a의 값 : %d\n", a);
	printf("a의 주소값 : %d\n", &a);
	printf("ptr_a에 저장된 값 : %d\n", ptr_a);
	printf("ptr_a가 가리키는 변수의 값 : %d\n", *ptr_a);
	*/

	// int a = 10;
	// int b = 20;
	// int *ptr;
	   
	// ptr = &a;
	// printf("ptr(a)이 가리키는 변수에 저장된 값 : %d\n", *ptr);
	   
	// ptr = &b;
	// printf("ptr(b)이 가리키는 변수에 저장된 값 : %d\n", *ptr);

	int a = 10;
	int *ptr;
	ptr = &a;

	printf("before a의 값 : %d\n", a);
	printf("before &a의 값- 주소 : %d\n", &a);
	printf("before *ptr의 값-주소에 연결된 값 : %d\n", *ptr);
	printf("before ptr의 값- 주소 : %d\n", ptr);
	
	*ptr = 20;
	printf("\n");

	printf("after a의 값 : %d\n", a);
	printf("after &a의 값-주소 : %d\n", &a);
	printf("after *ptr의 값-주소에 연결된 값 : %d\n", *ptr);
	printf("after ptr의 값-주소 : %d\n", ptr);
}






