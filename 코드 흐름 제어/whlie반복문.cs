using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 코드_흐름_제어
{
    internal class whlie반복문
    {
       public static void Show()
        {
            Console.WriteLine("while 반복문");

            int number = 0;
            // while() 조건식이 false가 될때까지 반복한다.
            while (number < 10)
            {

                Console.WriteLine(number++);

            }
            while (true) //조건식
            { 
                if(number == 10)
                {
                    break;
                }
            }

            // while문은 언제 사용하는가?
            // 얼마만큼 반복해야 할지 잘 모르겠을 때 while 반복문을 쓰면 좋다.
            int num2 = 0;
            while(num2 <= 10)
            {
                if(num2 % 2 == 0) //짝수라면...
                {
                    Console.WriteLine(num2);
                }
                num2 = num2 + 1;
                if(num2 == 10)
                {
                    break;
                }
            }
        }
    }
}