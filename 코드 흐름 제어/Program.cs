/*
 * 목표 : 게임 시작 메뉴 만들기 (C# 언어로)
 * 게임 시작, 게임 종료
 * 1. 두개의 선택 사항을 구분되서 코드를 제어하는 방법(조건문) if조건문, switch조건문
 * 2. 시작하자마자 프로그램이 종료가 되는 것을 방지, 계속해서 프로그램이 실행, 무한 반복문, for반복문, while 반복문
 */
namespace 코드_흐름_제어
{
    internal class Program
    {
        static void Main(string[] args)
        { ;
            Console.WriteLine("주말 c# 강의 3번째 클래스");
           Console.WriteLine("반복문과 조건문");

            while (true)
            {
                Console.WriteLine("실행할 강의를 선택해주세요. (1번 if조건문, 2번 switch 조건문, 3번 for반복문, 4번 while 반복문, 5번 메인로비)");
                int userInput = int.Parse(Console.ReadLine());

                if (userInput == 1)
                    if조건문.Show();
                else if (userInput == 2)
                    switch조건문.Show();
                else if (userInput == 3)
                    for반복문.Show();
                else if (userInput == 4)
                    whlie반복문.Show();
                else if (userInput == 5)
                    메인로비.ShowMenu();
                else
                {
                    Console.WriteLine("잘못된 입력입니다. 다시 입력해주세요.");
                }
            }



        }
    }
}
