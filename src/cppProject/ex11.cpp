#ifdef _MSC_VER
#define _CRT_SECURE_NO_WARNINGS
#endif

#include <stdio.h>

int main() {

	int choice;
	
	// goto 구문
	makeChoice:

	printf(" 선택지 1 \n");
	printf(" 선택지 2 \n");
	printf(" 선택지 3 \n");
	printf(" 선택지 4 \n");
	scanf("%d", &choice);

	switch (choice)
	{
		case 1 :
			printf(" 선택한 답지 1 ");
			break;
		case 2:
			printf(" 선택한 답지 2 ");
			break;
		case 3:
			printf(" 선택한 답지 3 ");
			break;
		case 4:
			printf(" 선택한 답지 4 ");
			break;
		
		default:

			// goto구문
			goto makeChoice;
			printf(" switch 그 외 ");
			break;
	}

}


