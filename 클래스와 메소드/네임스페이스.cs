/*
 * 학습 목표 : 이름 공간 (네임스페이스)의 대한 이해
 * 작성일 : 2024.08.17
 * 작성자 : 서사랑
 * 
 * 
 * 이름 : 다른 이름을 가짐으로써 구분할 수 있다.
 * 만약에 같은 이름이 중복되면 어떻게 될까?
 * -> 컴파일 에러가 발생한다. (실행이 안됩니다.)
 * 
 * 다른 비교할 기준이 있으면 두 대상을 구분 할 수 있게 된다.
 * 같은 이름을 분류하는 이름 공간
 * 
 * 2. 네임 스페이스 선언 방법
 * namespace 이름 공간의 이름 {    }   범위를 표현해주는 기호
 * 
 * 
 * 
 */




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 부산;
using 서사랑.수업내용;
using 클래스와_메소드;

namespace 부산
{
    class 밀면
    {
        int count;
    }
}


namespace 서울
{
    class 밀면
    {
        int count;
    }
       
}

namespace 스타벅스
{
    class 라떼
    {
        int count;
    }

}

namespace 스타벅스
{
    class 밀크티
    {
        int count;
    }
}

/*
            * using : 이름 공간을 사용해라
            * using 이름공간.이름공간; -> 네임 스페이스를 앞에 붙이지 않아도 그 공간 안에 있는 코드를 사용할 수 있다.
            * 
            */

namespace 서사랑
{
    namespace 수업내용
    {

        /*
         * 클래스
         * 사용자 정의 데이터 유형입니다. -> int,n float, string, char
         * 클래스를 이용하여 객채를 생성하고 그 객체 내부에 있는 변수와 메소드를 이용하여 데이터에 접근하고 사용할 수 있는 집합체입니다.
         * 
         * 1. 클래스의 선언
         * class 이름 { }
         * 
         * 
         * 2. 클래스의 사용
         * 
         * 
         */

        

class Monster
        {
            /* 공격한다 (행동)
             * 
             * 체력
             * 
             * 공격력
             * 
             * 방어력
             * 
             */

        }
    }
}

namespace 메이플스토리
{
    class 플레이어
    {
       public int HP;
        public int AttackPower;
       string Name;
       float MoveSpeed;

        public void Show()
        {
            Console.WriteLine($"플레이어의 체력 : {HP}");
            Console.WriteLine($"플레이어의 공격력 : {AttackPower}");
        }

        public void Attack(Slime slime)
        {
            slime.HP = slime.HP - AttackPower;
        }

        public void Rest()
        {
            HP = HP + 10;
        }

    }

    class Slime
    {
        // 슬라임의 체력은 50입니다. 실수형, 정수형
        /*
         * 접근 지정자
         * 1. public : 공공의, 외부에서 전부 사용할 수 있게 하라
         * 2. private : class 내부에서만 사용하라, 접근 지정자를 명사하지 않으면 자동으로 private 선언이 된다.
         * 
         * 
         */

        public int HP;
        public int AttackPower;
        public string Name;
        public float MoveSpeed;

        /*
         * 메소드 : 코드를 하나의 이름 아래 묶는 것입니다.
         * 묶인 코드를 이름을 불러주는 것만으로 실행할 수 있습니다.
         * 메소드를 호출하는 것을 Call methood (메소드 호출)
         * 
         * 
         * (접근 지정자) (반환값) (메소드의 이름) + () + {}
         * public         vold      Show()   {  묶인 코드의 내용들  }
         * 
         * 접근 지정자 : private, public => public 선언을 해주세요
         * 반환값이 없는 경우 : void
         * 반환값이 있는 경우 : int(정수형), float(실수형), String(문자열), class이름(사용자 정의형) 반환하라....
         * 
         * 
         */

        int ReturnHP()
        {

            // 반환값이 있는 함수일 경우에는 return + 변수의 이름 + ; => 해당하는 변수 값을 변환한다.
            return HP;
        }

        float ReturnMoveSpeed()
        {
            return MoveSpeed;
        }

        // 슬라임이 공격하는 메소드를 만들어보세요
        // 슬라임이 공격할 대상이 필요합니다.

        public void Attack(플레이어 pl)
        {
            pl.HP = pl.HP - AttackPower;
        }

        public void SpecialAttack(플레이어 pl)
        {
            pl.HP = pl.HP - AttackPower * 5;
        }
        public void Show()
        {
            Console.WriteLine($"{Name}의 체력 : {HP}");
            Console.WriteLine($"{Name}의 공격력 : {AttackPower}");
            Console.WriteLine($"{Name}의 이동속도 : {MoveSpeed}");
        }

    }

    class 초록달팽이
    {
        int HP;
        int AttackPawr;
        string Name;
        float MoveSpeed;

    }
}


namespace 클래스와_메소드
{
    internal class 네임스페이스
    {
        public void Show()
        {
            Console.WriteLine("Hello World!");
            스타벅스.라떼 noodle = new 스타벅스.라떼();
            스타벅스.밀크티 noodle2 = new 스타벅스.밀크티();
            
           

        }

           
    }
}

