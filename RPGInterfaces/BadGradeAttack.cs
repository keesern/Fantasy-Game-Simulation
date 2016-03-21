using System;

namespace Kee.RoleplayingGameInterfaces
{
    public class BadGradeAttack : NormalAttack
    {
        public override void Attack(ICharacter attacker, ICharacter target)
        {
            Console.WriteLine(attacker.Name + " gives a bad grade to " + target.Name + "!");
            base.Attack(attacker, target);
        }
    }
}
