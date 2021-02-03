#ifdef _MSC_VER
#define _CRT_SECURE_NO_WARNINGS
#endif

#include <stdio.h>


int main() {
	int i = 1;

	repeat:
	printf("%d\n", i);

	if (i < 10) {
		i++;
		goto repeat;
	}
}



