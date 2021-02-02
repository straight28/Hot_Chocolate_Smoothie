// #include <stdio.h>
// 
// 
// int main() {
// 	char a = 65;
// 
// 	printf(" %c ", a);
// }

#include <iostream>

int main() {
	int i, sum = 0;
	int user_input;

	for (i = 0; i < 10; i++) {
		std::cout << i << std::endl;
		sum += i;
	}

	std::cout << " 합은 : " << sum << std::endl;
	
	std::cout << " 입력 : ";

	std::cin >> user_input;  // cin은 cout처럼 std에 정의되어 있다. 

	std::cout << " 입력값은 " << user_input << std::endl;
	
	
	return 0;

}


