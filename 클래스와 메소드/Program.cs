using 메이플스토리;

namespace 클래스와_메소드
{
    internal class Program
    {
        static void PlayerTurn(플레이어 player, Slime slime)
        {
            Console.WriteLine("1. 공격한다");
            Console.WriteLine("2. 휴식한다.");

            int userInput = int.Parse(Console.ReadLine());

            if (userInput == 1)
            {
                player.Attack(slime);
            }
            else if (userInput == 2)
            {
                player.Rest();
            }
        }

        static void Main(string[] args)
        {
            네임스페이스 ns = new 네임스페이스();
            ns.Show();
            /*
             * 클래스 사용하는 방법
             * (이름공간.Slime) (클래스의 이름 변수) = new 메이플스토리.Slime();
             * 
             * 
             */

            메이플스토리.Slime slime = new 메이플스토리.Slime();
            slime.Name = "슬라임";
            slime.HP = 50;
            slime.AttackPower = 5;
            slime.MoveSpeed = 2.2f;
            slime.Show();

            메이플스토리.플레이어 pl = new 메이플스토리.플레이어();
            pl.HP = 100;
            pl.AttackPower = 5;

            int turn = 0;


            slime.Attack(pl);
            pl.Show();

            while(true)
            {
                turn = turn +1;

                Console.WriteLine($"{turn}일차");

                PlayerTurn(pl, slime);

                if(turn % 2 != 0) // 홀수
                {
                    slime.Attack(pl);
                }

                if(turn % 2 == 0) // 짝수
                {
                    slime.SpecialAttack(pl);
                }
                slime.Show();
                pl.Show();

                if(slime.HP <= 0)
                {
                    Console.WriteLine("슬라임을 처치했습니다. 게임에서 승리했습니다.");
                    break;
                }

                if(pl.HP <= 0)
                {
                    Console.WriteLine("플레이어가 사망했습니다. 게임에서 패배했습니다.");
                    break;
                }
            }
        }
    }
}