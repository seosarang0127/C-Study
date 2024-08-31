using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 클래스_상속;

namespace 클래스_상속
{

    class Monster
    {
            public int HP;
            public int AttackPower;

                public virtual void Attack(Player player)
            {
                 player.HP = player.HP - AttackPower;
                 //Console.WriteLine("몬스터가 플레이어를 공격함");
                 // 플레이어의 공격
                 // 슬라임 - 플레이어 공격
            }

        public void BeAttacked(Player player)
        {
            HP = HP - player.AttackPower;
            Console.WriteLine("플레이어가 몬스터를 공격함");
        }
    }

    internal class Slime : Monster
    {
        public override void Attack(Player player)
        {
            base.Attack(player);
        }

    }
}

