using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Study
{
    internal static class switch조건문
    {
        public static void Show()
        {
            Console.WriteLine
                ("switch 조건문 강의");

            int userInput = int.Parse(Console.ReadLine());

            switch(userInput)
            {
                case 1:
                case 2:
                    Console.WriteLine("1번 게임시작");
                    break;
                    Console.WriteLine("2번 게임종료");
                case 3:
                    break;
                    Console.WriteLine("3번 옵션");
                    break;
                default:
                    Console.WriteLine("잘못 입력했습니다. 다시 입력해주세요.");
                    break;
            }
            /*  if(uesrInt
             * 
             * 
             * 
             */
        }
    }
}
