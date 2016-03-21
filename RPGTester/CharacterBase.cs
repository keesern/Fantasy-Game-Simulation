using System;
using Liang.RoleplayingGameInterfaces;

namespace Liang.RPGCore
{
    public class CharacterBase : ICharacter
    {
        protected const string AnonymousName = "Anonymous";
        protected static int anonymousCounter = 0;
        protected IAttack attackBehavior;
        protected Random randomNumbers = new Random(); // Quick and dirty random number generator for dodge.

        public string CharacterClass
        {
            get;
            protected set;
        }

        public string Name
        {
            get;
            protected set;
        }

        public int Health
        {
            get;
            protected set;
        }

        public virtual void PerformAttack(ICharacter target)
        {
            attackBehavior.Attack(this, target);
        }

        public void ReceiveAttact(int damage)
        {
            if (randomNumbers.Next(GameConstants.Instance.DodgeDifficulty) != 0)
            {
                Console.WriteLine(Name + " takes " + damage + " damage.");
                Health -= damage;
                if (Health < 0)
                {
                    Health = 0;
                }
            }
            else
            {
                Console.WriteLine(Name + " dodges the Attack!");
            }
        }

        public override string ToString()
        {
            return String.Format("{0} the {1} has {2} health.", Name, CharacterClass, Health);
        }
    }
}
