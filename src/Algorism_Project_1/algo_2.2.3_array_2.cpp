#ifdef _MSC_VER
#define _CRT_SECURE_NO_WARNINGS
#endif 

#include <stdio.h>

// 문제 출처 - 안산학생의 찬란한 개발 블로그
// 9개의 서로 다른 자연수가 주어질 때, 이들 중 두 번째 최소값을 찾고,
// 그 두 번째 최소값이 몇 번째 수인지를 구하는 프로그램을 작성하시오. 
// 예를 들어, 서로 다른 9개의 자연수 3, 29, 38, 12, 57, 74, 40, 85, 61 이 주어지면,
// 이들 중 두 번째 최소값은 12이고, 이 값은 4번째 수이다.



int main() {

	int arr[9];
	int max, num;
	int min2, num2 = 0;
	int min = 0;

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
		if (arr[i] < min) {
			min = arr[i];
			num = i + 1;
		}
	}

	if (num == 1) {
		min2 = arr[1];
		num2 = 2;
	}
	else {
		min2 = arr[0];
		num2 = 1;
	}

	for (int i = 0; i < 9; i++)
	{
		if (i != num - 1) {
			if (arr[i] > min && arr[i] < min2) {
				min2 = arr[i];
				num2 = i + 1;
			}
		}
	}


	printf("\n");
	printf("두 번째 최소값은 : %d\n두 번째 최소값의 위치순서 : %d", min2, num2);


}


