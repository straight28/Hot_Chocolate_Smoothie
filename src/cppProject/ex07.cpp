#ifdef _MSC_VER
#define _CRT_SECURE_NO_WARNINGS
#endif

#include <stdio.h>

int main() {
	// int a, b;
	float c, d;

	// scanf 는 보안상의 문제가 있음.
	// 대신 scanf_s를 사용하게 함.
	// scanf 로 쓰려면 최상단에 아래와 같이 정의함
	//
	// #ifdef _MSC_VER
	// #define _CRT_SECURE_NO_WARINGS 을 최상단에 정의 해야함
	// #endif

	// scanf("%d%d", &a, &b);
	// int hap = a + b;
	// int cha = a - b;
	// int gop = a * b;
	// int mok = a / b;
	// int namuji = a % b;
	// 
	// printf("%d + %d = %d\n", a, b, hap);
	// printf("%d - %d = %d\n", a, b, cha);
	// printf("%d * %d = %d\n", a, b, gop);
	// printf("%d / %d = %d\n", a, b, mok);

	// printf(" ============================ ");
	// printf(" ============================ ");
	// printf(" ============================ ");

	scanf("%f%f", &c, &d);
	// float fhap = c + d;
	// float fcha = c - d;
	// float fgop = c * d;
	// float fmok = c / d;

	// printf("%f + %f = %f\n", c, d, fhap);
	// printf("%f - %f = %f\n", c, d, fcha);
	// printf("%f * %f = %f\n", c, d, fgop);
	// printf("%f / %f = %f\n", c, d, fmok);

	printf("%f + %f = %f\n", c, d, c + d);
	printf("%f - %f = %f\n", c, d, c - d);
	printf("%f * %f = %f\n", c, d, c * d);
	printf("%f / %f = %f\n", c, d, c / d);




}






