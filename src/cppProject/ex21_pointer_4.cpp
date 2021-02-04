#ifdef _MSC_VER
#define _CRT_SECURE_NO_WARNINGS
#endif // _MSC_VER

#include <stdio.h>

// 포인터의 포인터

#pragma region + 포인터의 포인터

// int main() {
// 
// 	int num = 10;				// 변수 선언
// 	int* ptr_num = &num;		// 포인터 선언
// 	int** pptr_num = &ptr_num;	// 포인터의 포인터
// 
// 	printf("변수 num가 저장하고 있는 값은 %d 이다\n", num);
// 	printf("포인터 ptr_num이 가리키고 있는 주소에 저장된 값은 %d 이다\n", *ptr_num);
// 	printf("포인터의 포인터 pptr_num가 가리키는 주소에, 저장된 포인터가 가리키는 주소에 저장된 값은 %d이다.\n", **pptr_num);
// 
// }

#pragma endregion

/*

void 포인터는 일반적인 포인터 변수와는 달리 대상이 되는 데이터의 타입을 명시하지 않은 포인터다

가능한 작업 :  변수, 함수, 포인터 등 어떠한 값도 가리킬 수 있다
불가능한 작업 : 포인터 연산이나 메모리 참조와 같은 작업
요약 : void 포인터는 주소값을 저장하는 것 이외에는 아무 것도 할 수 없는 포인터이다.
또한 void 포인터를 사용할 때에는 반드시 먼저 사용하고자 하는 타입으로 명시적 타입 변환 작업을 거친 후
사용해야 한다. 

*/

int main() 
{
	int num = 10;
	void* ptr_num = &num;

	printf("변수 num가 저장하고 있는 값은 %d 이다\n", num);
	printf("void 포인터 ptr_num가 가리키는 주소에 저장된 값은 %d이다 \n", *(int*)ptr_num);

	*(int*)ptr_num = 20; // void 포인터를 통한 메모리 접근
	printf("void 포인터 ptr_num가 가리키는 주소에 저장된 값은 %d이다 \n", *(int*)ptr_num);



}

