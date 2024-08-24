using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 코드_흐름_제어
{
    static class 메인로비
    {
        public static void GameStart()
        {
            int a = int.Parse(Console.ReadLine());
            if(a ==0)
            {
                Console.WriteLine("게임 시작 중");
            }
            else
            {
                Console.WriteLine("메뉴로 이동");
                ShowMenu();
            }
        }

        public static void OptionMenu()
        {
            int a = int.Parse(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("옵션 창");
            }
            else
            {
                Console.WriteLine("메뉴로 이동");
                ShowMenu();
            }
        }

        public static void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("==========게임 메뉴 출력==========");
            Console.WriteLine("1. 게임 시작");
            Console.WriteLine("2. 옵션");
            Console.WriteLine("3. 게임종료");

            while (true)
            {
                Console.WriteLine("입력을 기다리고 있습니다. : ");
                int userInput = int.Parse(Console.ReadLine());
                if (userInput == 1)
                {
                    Console.WriteLine("게임 시작!");
                    GameStart();
                    break;

                }
                else if (userInput == 2)
                {
                    Console.WriteLine("옵션!");
                    OptionMenu();
                    break;
                }
                else if (userInput == 3)
                {
                    Console.WriteLine("게임 종료!");
                    break;
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다. 다시 입력해주세요.");
                }

            }

        }
    }
}
