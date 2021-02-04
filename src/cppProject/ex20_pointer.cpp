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

/*

포인터란 메모리의 주소값을 저장하는 변수이며, 포인터 변수라고도 한다.
char형 변수가 문자를 저장하고, int형 변수가 정수를 저장하는 것처럼 
포인터는 주소값을 저장한다.

int n = 100; 변수의 선언
int *ptr = &n;  포인터의 선언
포인터 연산자
주소 연산자(&) - 변수의 이름 앞에 사용하여, 해당변수의 주소값을 반환
참조 연산자(*) - 가리키는 주소에 저장된 값을 반환

문법
타입* 포인터이름;

주의) 포인터를 선언한 후 참조 연산자(*)를 사용하기 전에 포인터는 반드시 먼저 초기화되어야 한다.
그렇지 않으면 의도하지 않은 메모리 값을 변경하게 된다.
따라서 C컴파일러는 초기화 하지 않은 포인터에 참조연산자를 사용하면, 오류를 발생

권장) 다음과 같이 포인터를 선언과 동시에 초기화를 함께 하는 것이 좋다.

타입* 포인터이름 = &변수이름;
타입* 포인터이름 = 주소값;

 */








