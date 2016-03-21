namespace Liang.RPGCore
{
    public class Warrior : CharacterBase
    {
        public Warrior()
            : this(AnonymousName + (++anonymousCounter), GameConstants.Instance.PlayerHitpoints)
        {

        }

        public Warrior(string name)
            : this(name, GameConstants.Instance.PlayerHitpoints)
        {

        }

        public Warrior(string name, int health)
        {
            CharacterClass = "Warrior";
            attackBehavior = new SwordAttack();
            Name = name;
            Health = health;
        }
    }
}
