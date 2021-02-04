#ifdef _MSC_VER
#define _CRT_SECURE_NO_WARNINGS
#endif // 

#include <stdio.h>

/*
포인터의 참조
C언어에서 선언된 포인터는 참조 연산자(*)를 사용하여 참조할 수 있다.
예제)
   int x = 7;			변수의 선언
   int *ptr = &x;		포인터의 선언
   int *pptr = &ptr;	포인터의 참조
*/

int main() {

	int num01 = 1234;
	double num02 = 3.14;
	int* ptr_num01 = &num01;
	double* ptr_num02 = &num02;


	printf("포인터의 크기는 %d 이다\n", sizeof(ptr_num01));
	printf("포인터의 크기는 %d 이다\n", sizeof(ptr_num02));
	printf("포인터 ptr_num01이 가리키고 있는 주소값은 %#x 이다. \n", ptr_num01);
	printf("포인터 ptr_num02이 가리키고 있는 주소값은 %#x 이다. \n", ptr_num02);

	printf("포인터 ptr_num01이 가리키고 있는 주소에 저장된 값은 %d이다. \n", *ptr_num01);
	printf("포인터 ptr_num02이 가리키고 있는 주소에 저장된 값은 %f이다. \n", *ptr_num02);



}




