#ifdef _MSC_VER
#define _CRT_SECURE_NO_WARNINGS
#endif

#include <stdio.h>

// & : 변수 또는 상수의 주소
// * : 포인터가 가리키는 주소에 저장된 값
// 포인터 : 변수의 주소를 저장하는 변수

int main() {
	int a = 20;
	int *ptr_a;
	ptr_a = &a;

	printf("%d\n", ptr_a);


}






