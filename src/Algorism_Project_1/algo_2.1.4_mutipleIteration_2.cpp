#ifdef _MSC_VER
#define _CRT_SECURE_NO_WARNINGS
#endif 

#include <stdio.h>

// 문제 출처 - 안산학생의 찬란한 개발 블로그
// 문제 : 자연수 n, m이 주어질 때, n 부터 m까지 존재하는 소수를 모두 
//		  출력하는 프로그램을 작성하시오.
// 소수란 약수가 1과 자기자신밖에 존재하지 않는 수를 말한다.


int main() {

	int n, m, sum, count = 0;

	printf("출력 테스트 \n");
    printf("숫자 범위를 입력하세요 ex) 1 300 엔터 \n");
	scanf("%d %d", &n, &m);

	for (int i = 0; i <= m ; i++)
	{
        sum = 0;
        for (int j = 1; j <= i; j++)
        {
            if (i % j == 0) {
                // 소수의 경우 1부터 자기자신까지 나눌 경우
                // 나머지가 0으로 떨어지는 경우는 1과 자기자신 2가지 뿐이다.
                sum++;
            }
        }

        if (sum == 2) {
            printf("%d", i);
            printf(" ");
            count++;
        }
	}

    printf("\n");
    printf("총 개수는 %d", count);


}



