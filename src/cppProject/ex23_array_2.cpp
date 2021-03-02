#ifdef _MSC_VER
#define _CRT_SECURE_NO_WARNINGS
#endif

#include <stdio.h>
#include <limits.h>
#include <stdlib.h>

int main(void) {
	int a = 5;
	int* b = &a;
	int** c = &b;

	printf("%d\n",a);
	printf("%d\n",*b);
	printf("%d\n",**c);

	system("pause");
	return 0;
}


//
//	int main(void) {
//		int a[] = { 1,2,3,4,5,6,7,8,9,10 };
//		int i;
//		for (int i = 0; i < 10; i++)
//		{
//			printf("%d\n", &a[i]);
//		}
//		system("pause");
//		return 0;
//	}


// int main(void) {
// 
// 	int a[10] = { 6,5,4,3,9,8,0,1,2,7 };
// 	int i, maxValue = INT_MIN;
// 
// 	for (i = 0; i < 10; i++)
// 	{
// 		if (maxValue < a[i]) {
// 			maxValue = a[i];
// 		} 
// 	}
// 
// 	printf("%d\n", maxValue);
// 	system("pause");
// 
// }


//
//	int main(void) {
//		char a[] = "Hello World";
//		int count = 0;
//		for (int i = 0; i <= 10; i++) {
//			if (a[i] == 'l') count++;
//	
//		}
//		printf("%d\n", count);
//		system("pause");
//		return 0;
//	}
//






