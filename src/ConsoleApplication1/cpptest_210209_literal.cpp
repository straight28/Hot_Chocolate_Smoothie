#ifdef _MSC_VER
#define	_CRT_SECURE_NO_WARNINGS
#endif 

#include <iostream>

 #pragma region + Code

//  int main() {
//  	char str[] = "literal";
//  	const char* pstr = "literal";
//  
//  	printf("str : %s \n", str);
//  	printf("pstr : %s \n", pstr);
//  
//  	printf("pstr : %d \n", "literal");
//  
//  	return 0;
//  }
//

#pragma endregion


// "sentence는 문자열이고, 주소값이다. "

// literal 이란 소스코드상에서 고정된 값을 가지는 것을 말한다.
// C언어의 경우 큰 따옴표 "" 로 묶인 것들을 문자열 리터럴이라고 부른다.

// 컴퓨터는 이러한 리터럴을 모아서 보관한다.
// 리터럴이 보관되는 곳은 오직 읽기만 가능 한 곳.
// 함부로 변경하려고 할 경우 프로그램은 강제로 종료되게 된다.

// 때문에 C에서는 문자열을 다루는 것이 어려운 편이다.

// 문자열을 자유롭게 다루기 위해서는 
// 아래와 같은 함수가 필요하다. 

// 1. 문자열 내의 총 문자의 수를 세는 함수
// 2. 문자열을 복사하는 함수
// 3. 문자열을 합치는 함수 
// 4. 문자열을 비교하는 함수

// 1. 문자열 내의 총 문자의 수를 세는 함수
//		null 종료 문자열
//		문자열의 끝이라고 알려주는 종료 문자. 이 종료문자는 아스키 값이 0이 아니라 48이고, '\0' 라고도 나타낸다.
//		말 그대로 널로 끝나는 문자라는 의미.
//		널 문자가 들어갈 공간이 있어야 하기 때문에 3 글자라고 해도, 배열은 4칸이 필요하게 된다.


int main() 
{
	char sentence_1[5] = { 'T','E','S','T', '\0' };
	char sentence_2[5] = { 'T','E','S','T', 0 };
	char sentence_3[5] = { 'T','E','S','T', (char)NULL };
	char sentence_4[5] = { "TEST" };

	printf("sentence_1 : %s \n", sentence_1);
	printf("sentence_2 : %s \n", sentence_2);
	printf("sentence_3 : %s \n", sentence_3);
	printf("sentence_4 : %s \n", sentence_4);

	// %c는 한 문자만을 출력하는 것이지만, 
	// %s를 이용한다면 null 이 나올때까지 문자를 계속 출력하게 됩니다.

	char ward[30] = { "long sentence" };
	char* str = ward;

	printf("%s \n",str);
	// char* 를 이용하여 char 배열을 가리키고 있다.
	// 따라서 str이라는 char을 가리키는 포인터가 배열 word를 가리친다.
	// 즉 str이 가리키는 것을 문자열로 출력한다. 

	int str_length(char* name);
	char name[] = "What is your name ?";

	printf(" 이 문자열의 길이 : %d \n ", str_length(name));



	return 0;

}





