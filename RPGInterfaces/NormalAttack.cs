using System;

namespace Kee.RoleplayingGameInterfaces
{
    public class NormalAttack : IAttack
    {
        protected Random randomNumbers = new Random();
        public virtual void Attack(ICharacter attacker, ICharacter target)
        {
            int damage = GameConstants.Instance.DamageBonus + 
                randomNumbers.Next(GameConstants.Instance.DamageRange);
            target.ReceiveAttact(damage);
        }
    }
}
