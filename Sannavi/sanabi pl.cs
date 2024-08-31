using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sannavi
{
    internal class sanabi_pl
    {
            public int HP;
            public int AttackPower;

        public void Attack(Monster robot)
        {
            // 플레이어의 공격
            // 슬라임 - 플레이어 공격
            robot.HP = robot.HP - AttackPower;
            Console.WriteLine("사슬팔의 공격!");
            Console.WriteLine($"애니매트로닉스의 현재 체력 : {robot.HP}");
        }

        public void BeAttacked(Monster robot)
        {
            HP = HP - robot.AttackPower;
        }
    }
}
