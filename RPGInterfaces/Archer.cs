namespace Kee.RoleplayingGameInterfaces
{
    public class Archer : CharacterBase
    {
        public Archer()
            : this(AnonymousName + (++anonymousCounter), GameConstants.Instance.PlayerHitpoints)
        {

        }

        public Archer(string name)
            : this(name, GameConstants.Instance.PlayerHitpoints)
        {

        }

        public Archer(string name, int health)
        {
            CharacterClass = "Archer";
            attackBehavior = new BadGradeAttack();
            Name = name;
            Health = health;
        }
    }
}
