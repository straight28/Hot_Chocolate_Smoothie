#ifdef _MSC_VER
#define _CRT_SECURE_NO_WARNINGS
#endif 

#include <stdio.h>


#pragma region + 값에 의한 전달 (call by value)
//
// void local(int);
// 
// int main(void)
// {
// 	int var = 10;
// 
// 	printf("변수 var의 초기값은 %d 입니다 \n", var);
// 
// 	local(var);
// 
// 	printf("local() 함수 호출 수 변수 var의 초기값은 %d 입니다 \n", var);
// 
// 	return 0;
// 
// }
// 
// 
// void local(int num)
// {
// 	num += 10;
// }

#pragma endregion


#pragma region + 참조에 의한 전달 (call by reference)

void local(int*);

int main(void) {
	int var = 10;
	printf("변수 var의 초기값은 %d이다 \n", var);

	local(&var);
	printf("local() 함수 호출 후 변수 var의 초기값은 %d이다 \n", var);

	return 0;
}

void local(int* num)
{
	*num += 10;
}

// local 함수의 매개변수 num은 인수로 변수 var의 주소값을 전달 받는다.
// 따라서 함수 내에서 매개변수 num의 값을 변경하면, 원래 인수인 변수 var의 값도 같이 변경 된다.

#pragma endregion


