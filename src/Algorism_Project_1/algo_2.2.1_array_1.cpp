#ifdef _MSC_VER
#define _CRT_SECURE_NO_WARNINGS
#endif 

#include <stdio.h>

// 문제 출처 - 안산학생의 찬란한 개발 블로그
// 9개의 서로 다른 자연수가 주어질 때, 이들 중 최대값을 찾고 그 최대값이 몇 번째 수인지를 구하는 프로그램을 작성하시오.
// 예를 들어, 서로 다른 9개의 자연수 3, 29, 38, 12, 57, 74, 40, 85, 61 이 주어지면,
// 이들 중 최대값은 85이고, 이 값은 8번째 수이다.


int main() {
	
	int arr[9];
	int max, num;

	printf("출력테스트 \n");
	printf("출력할 배열까지의 수를 입력하세요\n ");
	
	for (int i = 0; i < 9; i++)
	{
		scanf("%d", &arr[i]);

	}

	max = arr[0];
	num = 1;

	for (int i = 0; i < 9; i++)
	{
		if (arr[i] > max) {
			max = arr[i];
			num = i + 1;
		}
	}
	
	printf("\n");
	printf("최대값은 : %d\n최대값의 위치순서 : %d", max, num);


}

