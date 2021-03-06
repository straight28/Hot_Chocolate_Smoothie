﻿#ifdef _MSC_VER
#define _CRT_SECURE_NO_WARNINGS
#endif 

#include <stdio.h>

/*
	포인터와 배열의 관계
	- 포인터와 배열은 긴밀한 관계가 있으며, 어떤 부분에서는 서로 대체할 수도 있다.
	- 배열의 이름은 그 값을 변경할 수 없는 상수라는 점을 제외하면 포인터와 동일하다.
	따라서 배열의 이름은 포인터 상수이다.

	포인터배열 : 포인터 변수가 가리키고 있는 주소 값을 변경할 수 없는 포인터를 의미
				 포인터가 여러개 모여서 배열로 존재 
	배열포인터 : 상수포인터란 상수를 가리키는 포인터를 의미
				 배열타입을 가리키는 하나의 포인터

*/

int main() 
{
	int arr[3] = { 10, 20, 30 };	// 배열 선언
	int* ptr_arr = arr;				// 포인터에 배열의 이름을 대입함

	printf("배열의 이름을 이용하여 배열 요소에 접근 : %d %d %d\n", arr[0], arr[1], arr[2]);
	printf("	포인터를 이용하여 배열 요소에 접근 : %d %d %d\n", ptr_arr[0], ptr_arr[1], ptr_arr[2]);

	// --> int 형 배열요소 3개의 크기로 출력
	printf("배열의 이름을 이용하여 배열의 크기 계산 : %d\n", sizeof(arr));

	// --> 배열의 크기가 아닌 포인터 변수 자체의 크기가 출력
	printf("	포인터를 이용하여 배열 크기 계산 : %d\n", sizeof(ptr_arr));

}

/*

배열의 이름과 포인터 사이에는 다음과 같은 공식이 성림 (http://www.tcpschool.com/c/c_pointerArray_relation)
	-> arr이 배열의 이름이거나 포인터이고 n이 정수일 때,
	-> arr[n] == *(arr + n)

배열과 관계된 연산을 할 때는 언제나 배열의 크기를 넘어서는 접근을 하지 않도록 주의 필요
포인터 연산을 이용하여 계산하다가 배열의 크기를 넘어서는 접근을 하는 경우, C컴파일러는 어떠한 오류도
발생시키지 않음.

다만 잘못된 결과만을 반환하므로 C언어로 프로그래밍 할 때에는 언제나 배열의 크기에 주의 필요 



*/



