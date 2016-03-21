using System;
using Liang.RoleplayingGameInterfaces;

namespace Liang.RPGCore
{
    public class FireAttack : NormalAttack
    {
        public override void Attack(ICharacter attacker, ICharacter target)
        {
            Console.WriteLine(attacker.Name + " launches a fireball at " + target.Name + "!");
            base.Attack(attacker, target);
        }
    }
}
