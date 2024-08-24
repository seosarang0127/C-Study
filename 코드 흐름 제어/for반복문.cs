﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 코드_흐름_제어
{
    internal class for반복문
    {


        public static void Show()
        {
            Console.WriteLine("for 반복문");

            // 1.반복문을 왜 사용하는가? 기능적으로 반복되는 부분을 문법적으로 표현하기 위해서 반복문을 사용한다.

            for(int i = 0; i < 1; i++)
            {
                // i의 값이 조건식에 해당하면 중괄호 내부를 실행한다.
                // 변화식의 값으로 i를 변화시킨다.
                Console.WriteLine(i + 1);
            }

            // 2. 반복문 : for문을 언제 사용하는가?
            // 반복할 횟수가 정해져있는 경우 : for 반복문을 사용하면 좋다.
            // 반복할 횟수가 정해져있지 않고 특정 case에 종료되는 경우 : while반복문을 사용하면 좋다.

            // 3. fot문의 조건식이 항상 참이면 어떻게 되는가?

            int num = 0;

            for(; ;)      // for 무한 반복문
            {
                //탈출할 수 있는 조건을 추가해줍니다.
                Console.WriteLine(num++);
                if(num == 10)
                {
                    Console.WriteLine("탈출하기!");
                    break;

                }
            }
        }
    }
}
