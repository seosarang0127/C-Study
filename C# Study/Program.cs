// 주석
// 1. 슬레시 두번 2. 슬레기 쉬프트 *
/*
 * 프로그래밍 : 컴퓨터로 프로그래밍을 작동시키는 작업
 * 언어 : 컴퓨터와 사람이 대화하기 위한 언어
 * 번역기 통역사 -> 컴파일러 : 사람과 컴퓨터 사이에 번역을 해주는 기계
 * c언어, c++, c#, 파이썬, 자바, 타임
 * 
 * 확장자마다 번역기가 따로 있다.
 * 컴퓨터 사람이 사용하는 언어를 표현하는 방법을 모방하려면
 * 정수는 정수 방식으로 표현한다.
 * 키워드? 이미 의미가 정해져있는 단어. 파란색으로 표시 되어 있는 단어
 * 흰색 : 어떤 것(데이터 타입)의 이름
 * 밝은 노란색 : 함수
 * 
 * 정수는 정수 방식으로 표현한다.
 * 실수는 실수 방식으로 표현한다.
 * 문자는 문자 방식으로 표현한다.
 * 
 * 정수 방식으로 사용하는 키워드 : int
 * 실수 방식으로 사용하는 키워드 : float
 * 단어 방식으로 사용하는 키워드 : char
 * 문자열 방식으로 사용하는 키워드 : string
 * 
 */
using System.Diagnostics;

namespace C__Study
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            
            Console.WriteLine("컴퓨터에게 정수, 실수, 문자, 문자열을 입력시켜본다.");
            
            // 변수 : 변하는 수. 출력할 때 값이 다를 수 있는 형태.
            // 변수의 선언
            // 키워드 해당키워드의 이름;
            // 키워드 : int(띄어쓰기)
            // 이름 : number
            // ; : 세미클론. 해당 코드가 끝났다라는 사실을 알려주는 키워드.
            
            int number; // 정수를 저장할 수 있는 변수를 선언하는데 그 녀석의 이름이 number
            number = 10; // number 변수에 10을 대입하라라는 뜻이다.
            
            // 정수형 변수로 이름을 num으로 선언해서 그 변수에 100이라는 숫자를 넣어보세요.
            
            int num;
            num = 100;
            // 초기화 : 변수의 선언과 동시에 데이터를 넣는 것.
            int num2 = 200;

            // Ctrl + K + C : 전체 선택 범위 주석 처리
            // ctrl + K + U : 

            Console.WriteLine(number);
            Console.WriteLine(num);
            Console.WriteLine(num2);

            Console.WriteLine(10 + 100);
            int num3 = 10;
            int num4 = 20;
            Console.WriteLine(num3 + num4); // 더하기
            Console.WriteLine(num3 - num4); // 빼기
            Console.WriteLine(num3 * num4); // 곱하기
            Console.WriteLine(num3 / num4); // 나누기
            Console.WriteLine(num3 % num4); // 나머지

            // 키워드를 하나 선택
            // 변수의 선언
            // 변수의 초기화
            // 변수의 사칙연산

            //char c1 = 'c';
            //char c2 = 'w';
            //
            //Console.WriteLine(c1 + c2);
            //
            //string s1 = "문자열은 ";
            //
            //string s2 = "처음 만들어보는 c# 프로그램";
            //
            //Console.WriteLine(s1 + s2);
            //
            //
            //Console.WriteLine("두 수를 더해주는 프로그램입니다.");
            //Console.WriteLine("첫번째 숫자를 입력해주세요.");
            //
            //
            //string input;
            //input = Console.ReadLine();
            //
            //Console.WriteLine("float 값 3개를 입력 받아서 더하는 프로그램");
            //Console.WriteLine("첫번째 숫자를 입력해주세요.");
            //
            //string inputt;
            //input = Console.ReadLine();
            //int inputNumber = int.Parse(input);
            //
            //Console.WriteLine("두번째 숫자를 입력해주세요.");
            //string inputA = Console.ReadLine();
            //int inputNumber2 = int.Parse(inputA);
            //
            //Console.WriteLine("세번째 숫자를 입력해주세요.");
            //string inputB = Console.ReadLine();
            //int inputNumber3 = int.Parse(inputB);
            //
            //Console.WriteLine("덧셈 결과 : " + input + inputA + inputB);



            Console.WriteLine("가로의 크기를 입력해주세요.");
            string inputD= Console.ReadLine();
            int inputDNumber = int.Parse(inputD);
            Console.WriteLine("세로의 크키를 입력해주세요.");
            string inputC = Console.ReadLine();
            int inputCNumber = int.Parse(inputC);

            Console.WriteLine(inputDNumber * inputCNumber);
        }
    }
}