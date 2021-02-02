#include <stdio.h>

int main() {
	// int a = 2;
	// int b = 5;
	// int hap = a + b;
	// 
	// printf(" %d + %d = %d\n ", a, b, hap);


	// int: 32바이트(4바이트), 정수를 담는데 쓰임
	int a = 5;
	int b = 3;

	int hap = a + b;
	int cha = a - b;
	int gop = a * b;
	int mok = a / b;
	int namuji = a % b;

	printf("%d + %d = %d\n", a, b, hap);
	printf("%d - %d = %d\n", a, b, cha);
	printf("%d * %d = %d\n", a, b, gop);
	printf("%d / %d = %d\n", a, b, mok);
	printf("%d % %d = %d\n", a, b, namuji);
	
	printf("\n");
	printf(" ====================================== \n");
	printf("\n");

	// float : 32비트(4바이트), 실수를 담는데 쓰임
	// 부동소수점 

	float c = 5;
	float d = 3;

	float fhap = c + d;
	float fcha = c - d;
	float fgop = c * d;
	float fmok = c / d;

	printf("%f + %f = %f\n", c, d, fhap);
	printf("%f - %f = %f\n", c, d, fcha);
	printf("%f * %f = %f\n", c, d, fgop);
	printf("%f / %f = %f\n", c, d, fmok);


	printf("\n");
	printf(" ====================================== \n");
	printf("\n");

	// double : 64비트(8바이트), 실수를 담는데 쓰임
	// 저장공간이 2배가 되어, 표현 가능한 숫자의 개수는 제곱이 된다
	double e = 5;
	double f = 3;

	double dhap = e + f;
	double dcha = e - f;
	double dgop = e * f;
	double dmok = e / f;

	printf("%f + %f = %f\n", e, f, dhap);
	printf("%f - %f = %f\n", e, f, dcha);
	printf("%f * %f = %f\n", e, f, dgop);
	printf("%f / %f = %f\n", e, f, dmok);

	printf("\n");
	printf(" ====================================== \n");
	printf("\n");

	// 기본 정리

	// 10 진법 
	// 12345 = 10000 + 2000 + 300 + 40 + 5
	//		 = 1*10^4 + 2*10^3 + 3*10^2 + 4*10^1 + 5*10^0
	//

	// 2진법 - 0, 1 로만 구성
	// 100110(2) = 1*2^5 + 1*2^2 + 1*2^1 = 38
	//
	// int - 32비트 = 4바이트
	// 00000000 00000000 00000000 00100101
	// 5 = 101(2)
	// 37 = 100101(2)
	//
	// 8비트 = 1바이트
	// 바이트: 컴퓨터에서 데이터를 처리하는 가장 작은 단위
	//
	// 자료형 - 정수형, 실수형 
	// char (1바이트) - 문자를 담음
	// short (2바이트)
	// long (4바이트) = -2147483648 ~ 2147483648 
	// long long (8바이트)
	// int (시스템에 따라서 자동결정, 대체로 long
	// 
	// 실수형
	// float (4바이트)
	// double (8바이트)
	// 
	// unsigned, signed
	// 
	// 11111111 11111111 11111111 11111111 = -1
	// unsigned = 맨앞 부호를 무시하겠다. 
	// unsigned int a = 0 ~ 4294967295
	// 
	// void : 리턴 값이 없는 함수의 자료형
	// bool : 참, 거짓을 저장 (=char)



}

