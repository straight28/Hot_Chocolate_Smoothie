#ifdef _MSC_VER
#define _CRT_SECURE_NO_WARNINGS
#endif

#include <stdio.h>

int main() {
	int a, b;

	scanf("%d%d", &a, &b); 
	// scanf 는 보안상의 문제가 있음.
	// 대신 scanf_s를 사용하게 함.
	// scanf 로 쓰려면 최상단에 아래와 같이 정의함
	//
	// #ifdef _MSC_VER
	// #define _CRT_SECURE_NO_WARINGS 을 최상단에 정의 해야함
	// #endif

	int hap = a + b;
	int cha = a - b;
	int gop = a * b;
	int mok = a / b;
	int namuji = a % b;

	printf("%d + %d = %d\n", a, b, hap);
	printf("%d - %d = %d\n", a, b, cha);
	printf("%d * %d = %d\n", a, b, gop);
	printf("%d / %d = %d\n", a, b, mok);

}






