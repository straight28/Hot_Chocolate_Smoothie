#ifdef _MSC_VER
#define _CRT_SECURE_NO_WARNINGS
#endif 

#include <stdio.h>

#pragma region + float test1

// 1. 두 숫자를 입력받아서 그 숫자들의 합을 출력하는 프로그램

// int main() {
// 	float a;
// 	float b;
// 
// 	printf(" 두 개의 수를 입력하세요 \n");
// 	scanf("%f%f", &a, &b);
// 	printf(" 입력한 두 수의 합은 ? %f", a+b );
// }


#pragma endregion

#pragma region + double test2

// int main() {
// 	double a;
// 	double b;
// 
// 	printf(" 두 개의 double형 값을 입력하세요ㅣ ");
// 	scanf("%lf %lf", &a, &b);
// 	printf(" 입력하신 두개의 double형 값의 합은 ? %lf", a + b);
// }

#pragma endregion

#pragma region + bmi 테스트

// 2. 체중(kg, 실수)과 키(m, 실수)를 입력받아서 체질량 지수를 구하는 프로그램 ( (몸무게) / (키)2 )
// int main() {
// 
// 	float a;
// 	float b;
// 	float c;
// 
// 	printf(" 계산을 시작합니다. 다음의 값을 입력하세요 \n ");
// 	printf(" 몸무게를 입력하세요 \n");
// 	scanf(" %f", &a);
// 	printf(" 키를 입력하세요 \n");
// 	scanf(" %f", &b);
// 
// 	b = b * b;
// 	c = a / b;
// 
// 	printf(" 계산 중 ... \n");
// 	printf(" BMI는 %f 입니다 \n", c);
// 
// }


#pragma endregion

#pragma region + 알파벳 출력

// // 3. 알파벳을 입력받아서 그 다음 알파벳을 출력하는 프로그램 Z 제외
// int main() {
// 	char a;
// 	char b;
// 
// 	printf(" 알파벳을 입력하세요 \n");
// 
// 	scanf("%c", &a);
// 
// 	b = a + 1;
// 
// 	printf(" 다음알파벳은 %c 입니다. \n", b);
// 
// }
// 

#pragma endregion

int main() {
	int a;
	printf(" 숫자 a는 ? \n");
	scanf("%d", &a);

	bool p = (a >= 1) && (a <= 10);
	bool q = a == 3 || a == 7;
	bool r = !q;

	printf("정의 - True : 1 /// False : 0 \n");
	printf("내용1 - p는 a>1보다 크고, 10보다 작다 %d\n", p);
	printf("내용2 - q는 a는 3과 같거나 7과 같다 %d\n", q);
	printf("내용3 - r은 q가 아니다 %d\n", r);

}




