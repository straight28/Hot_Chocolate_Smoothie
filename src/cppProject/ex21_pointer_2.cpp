#ifdef _MSC_VER
#define _CRT_SECURE_NO_WARNINGS
#endif 

#include <stdio.h>


// 포인터끼리의 비교연산과 대입연산

int main() {

	int num01 = 10;
	int num02 = 20;

	int* ptr_num01 = &num01;
	int* ptr_num02 = &num02;

	if (ptr_num01 != ptr_num02)  // 포인터끼리의 비교 연산
	{
		printf("포인터 ptr_num01이 가리키고 있는 주소에 저장된 값은 %d입니다 \n", *ptr_num01);
		printf("포인터 ptr_num02이 가리키고 있는 주소에 저장된 값은 %d입니다 \n", *ptr_num02);
		printf("포인터 ptr_num01과 ptr_num02는 현재 다른 주소를 가리키고 있습니다 \n\n");
		ptr_num02 = ptr_num01;  // 포인터끼리의 대입연산
	}

	printf("포인터 ptr_num01이 가리키고 있는 주소에 저장된 값은 %d입니다.\n", *ptr_num01);
	printf("포인터 ptr_num02가 가리키고 있는 주소에 저장된 값은 %d입니다.\n", *ptr_num02);

	if (ptr_num01 == ptr_num02) // 포인터끼리의 비교 연산
	{
		printf("포인터 ptr_num01과 ptr_num02는 현재 같은 주소를 가리키고 있습니다.\n");
	}
}

/*
포인터의 연산

포인터는 값을 증가 혹은 감소시키는 등의 제한된 연산만이 가능
C언어의 포인터 연산에는 아래와 같은 규칙이 존재

	1. 포인터끼리의 덧셈, 곱셈, 나눗셈은 아무런 의미가 없다.
	2. 포인터끼리의 뺄셈은 두 포인터 사이의 상대적 거리를 나타낸다.
	3. 포인터에 정수를 더하거나 뺄수는 있지만, 실수와의 연산은 허용하지 않는다.
	4. 포인터끼리 대입하거나 비교할 수 있다.

*/
/*
int main() {

	char* ptr_char = 0;
	int* ptr_int = NULL;
	double* ptr_double = 0x00;

	printf("포인터 ptr_char가 현재 가리키고 있는 주소값은 %#x 이다\n", ptr_char);
	printf("포인터 ptr_int가 현재 가리키고 있는 주소값은 %#x 이다\n", ptr_int);
	printf("포인터 ptr_double이 현재 가리키고 있는 주소값은 %#x 이다\n", ptr_double);

	printf("포인터 ptr_char가 1증가 후에 가리키고 있는 주소값은 %#x 이다\n", ++ptr_char);
	printf("포인터 ptr_int가 1증가 후에 가리키고 있는 주소값은 %#x 이다\n", ++ptr_char);
	printf("포인터 ptr_double이 1증가 후에 가리키고 있는 주소값은 %#x 이다\n", ++ptr_char);

}
*/

