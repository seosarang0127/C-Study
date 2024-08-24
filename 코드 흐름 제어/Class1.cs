using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 코드_흐름_제어
    /*
     * static 키워드를 선언하면..
     * 클래스의 인스턴스가 아니라 객체 그 자체에 접근하게 한다.
     * if조건문.Show();
     */
{
    static class if조건문
    {
        public static void Show()
        {
            Console.WriteLine("if조건문");

            /*
             * 1. 위에서부터 순서대로 실행되는 구조가 아닌 선택으로 실행되는 코드의 흐름 제어
             * 1-1 조건식 : 이 조건문을 실행할지 말지 결정하는 문
             * 
             * true : 실행이 된다. /  false : 실행이 안된다.
             */
            if(true)

            {
                Console.WriteLine("if문이 실행됨");
            }

            int num = int.Parse(Console.ReadLine());
            if(num > 5)
            {
                Console.WriteLine("num이 5보다 큽니다.");
            }
            else //if와 함께 사용해야하며, 위의 if조건문이 아닐 때 실행한다.
            {
                Console.WriteLine("num이 5보다 작거나 같습니다.");

                Console.WriteLine("숫자를 입력해주세요 : ");
                int num2 = int.Parse(Console.ReadLine());
                if (num2 > 5)
                {
                    Console.WriteLine("num2가 5보다 큽니다.");
                    if (num2 > 5)
                        Console.WriteLine("조건문이 한줄인 경우에는 중괄호 없이 표현할 수 있다.");
                    else
                        Console.WriteLine("num가 5보다 작거나 같습니다.");

                    if (num2 > 5)
                        Console.WriteLine("num가 5보다 큽니다.");     //조건문의 영향을 받는다.
                    Console.WriteLine("그리고 이것도 출력됩니다.");     //조건문과 상관없이 항상 실행된다.
                    Console.Write("입력 값을 넣어주세요(1 : 게임시작, 2: 게임종료, 3: 옵션  : ");
                    int userInput = int.Parse(Console.ReadLine());

                    if (userInput == 1)
                    {
                        Console.WriteLine("1. 게임시작");
                    }
                    else if (userInput == 2)
                        Console.WriteLine("2. 게임종료");
                    else if (userInput == 3)
                        Console.WriteLine("3. 옵션");
                }
            }
        }
    }
}
