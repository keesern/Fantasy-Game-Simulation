using System;

namespace Kee.RoleplayingGameInterfaces
{
    public class BowAttack : NormalAttack
    {
        public override void Attack(ICharacter attacker, ICharacter target)
        {
            Console.WriteLine(attacker.Name + " bows to " + target.Name + "!");
            base.Attack(attacker, target);
        }
    }
}
