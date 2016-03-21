using System;
using Liang.RoleplayingGameInterfaces;

namespace Liang.RPGCore
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
