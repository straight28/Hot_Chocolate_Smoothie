#ifdef _MSC_VER
#define _CRT_SECURE_NO_WARNINGS
#endif 

#include <stdio.h>

int main() {
	double celsius;

	printf(" 섭씨 온도를 화씨 온도로 바꿔주는 프로그램. \n");
	printf(" 섭씨 온도를 입력해 주세요 : ");

	scanf("%lf", &celsius);

	printf(" 섭씨 %f도는 화씨로 %f도 입니다. \n", celsius, 9 * celsius / 5 + 32);

	return 0;


}
