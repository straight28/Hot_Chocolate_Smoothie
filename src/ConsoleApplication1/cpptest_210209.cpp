#ifdef _MSC_VER
#define _CRT_SECURE_NO_WARNINGS
#endif 

#include <iostream>

// int main() 
// {
// 	int sum = 0;
// 
// 	for (int i = 1; i <= 10; i++)
// 	{
// 		sum += i;
// 	}
// 
// 	std::cout << " 합은 : " << sum << std::endl;
// 	
// 
// 
// 	int j = 1, sum1 = 0;
// 
// 	while (j <= 10)
// 	{
// 		sum1 += j;
// 		j++;
// 	}
// 
// 	std::cout << " 합은 : " << sum1 << std::endl;
// 
// }

int main() {
	int luncky_number = 3;

	std::cout << " 숨겨진 수를 맞춰 보세요 " << std::endl;

	int user_input;

	while (true)
	{
		std::cout << " 입력 : ";
		std::cin >> user_input;

		if (luncky_number == user_input)
		{
			std::cout << " 정답 " << std::endl;
			break;
		}
		else {
			std::cout << " 재도전 " << std::endl;
		}

	}
	return 0;
}

