#ifdef _MSC_VER
#define _CRT_SECURE_NO_WARNINGS
#endif 

#include <stdio.h>

// 파스칼의 삼각형

/*
1
1	1
1	2	1
1	3	3	1

j == 0 || j == i -> i
i행 j열 = [i - 1 j - 1] + [i - 1 j]
*/

int main() {
	int p[20][20];

	for (int i = 0; i < 20; i++)
	{
		for (int j = 0; j <= i ; j++)
		{
			// 맨 첫 부분 || 맨 끝 부분
			if (j == 0 || j == i) {
				p[i][j] = 1;
			}
			else {
				p[19][18] = p[18][17] + p[1][0];
				p[i][j] = p[i - 1][j - 1] + p[i - 1][j];
			}

			printf("%d ", p[i][j]);
		}
		printf("\n");
	}
}
