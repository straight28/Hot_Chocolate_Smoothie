#ifdef _MSC_VER
#define _CRT_SECURE_NO_WARINGS
#endif 

#include <iostream>

#pragma region + iostream

// int change_val(int *p)
// {
// 	// 주소값을 참조하여, 값을 3으로 변경
// 	*p = 3;
// 
// 	return 0;
// }
// 
// int main() 
// {
// 	int number = 5;
// 
// 	std::cout << number << std::endl;
// 
// 	// change_val에 number의 주소값을 전달
// 
// 	change_val(&number);
// 	std::cout << number << std::endl;
// 
// }


#pragma endregion


int main() 
{
	int a = 3;
	int& another_a = a;   
	// 참조자 &    int& int형 참조자
	// int*&  포인터 타입의 참조자
	// another_a 는 a의 또다른 이름

	// 참조자의 경우 한번 어떤 변수의 참조자가 되면, 더이상 다른 변수를 참조할 수 없다.


	another_a = 5;
	std::cout << " a :" << a << std::endl;
	std::cout << " another_a : " << another_a << std::endl;

	return 0;

}



