#ifdef _MSC_VER
#define _CRT_SECURE_NO_WARNINGS
#endif 

#include <stdio.h>

// 문제 출처 - 안산학생의 찬란한 개발 블로그

#pragma region + 문제 : n층의 삼각형을 출력하는 프로그램 작성

// 문제 : n층의 삼각형을 출력하는 프로그램 작성
// int main() {
// 
// 	int n;
// 	printf("출력테스트 \n");
// 	
// 	printf("출력할 정수 n을 입력하세요 \n");
// 	scanf("%d", &n);
// 
// 
// 	for (int i = 0; i <=n; i++)
// 	{
//        if (i > 0) {
//            printf("%d번줄 : ", i);
//        }
//        
// 		for (int j = 0; j < i; j++)
// 		{
// 			printf("*");
// 		}
//
// 		printf("\n");
// 	}
// 	
// 	return 0;
// }

#pragma endregion

// 문제 : n층의 삼각형을 출력하는 프로그램 작성 (공백과 *의 개수 일치)

int main() {

    int n, sum = 0;
    printf("출력테스트 \n");

    printf("출력할 정수 n을 입력하세요 \n");
    scanf("%d", &n);
    printf("\n");

    for (int i = 0; i < n; i++)
    {
        
        printf("%d번줄 : ", i+1);

        for (int b = n-1; b > i; b--)
        {
            printf(" ");
        }

        for (int j = 0; j <= i; j++)
        {
            printf("*");
        }

        if (sum != 0) {
            for (int c = 0; c < i; c++)
            {
                printf("*");
            }
        }
        else {
            sum++;
        }
      

        printf("\n");
    }

    return 0;
}



