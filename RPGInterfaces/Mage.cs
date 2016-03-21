namespace Kee.RoleplayingGameInterfaces
{
    public class Mage : CharacterBase
    {
        public Mage()
            : this(AnonymousName + (++anonymousCounter), GameConstants.Instance.PlayerHitpoints)
        {

        }

        public Mage(string name)
            : this(name, GameConstants.Instance.PlayerHitpoints)
        {

        }

        public Mage(string name, int health)
        {
            CharacterClass = "Mage";
            attackBehavior = new FireAttack();
            Name = name;
            Health = health;
        }
    }
}
