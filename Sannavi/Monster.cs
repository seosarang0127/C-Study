using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Sannavi
{

    internal class Monster

    {
        public int HP;
        public int AttackPower;
        public virtual void Attack(sanabi_pl player1)
        {
            player1.HP = player1.HP - AttackPower;

        }

        public void BeAttacked(sanabi_pl player1)
        {
            HP = HP - player1.AttackPower;
            Console.WriteLine("사슬팔이 애니매트로닉스를 공격함");
        }
    }

internal class Slime : Monster
{
    public override void Attack(sanabi_pl player1)
    {
        base.Attack(player1);
    }
}
}
