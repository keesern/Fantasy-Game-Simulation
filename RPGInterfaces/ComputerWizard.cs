namespace Kee.RoleplayingGameInterfaces
{
    public class ComputerWizard : CharacterBase
    {
        public ComputerWizard()
            : this(AnonymousName + (++anonymousCounter), GameConstants.Instance.PlayerHitpoints)
        {

        }

        public ComputerWizard(string name)
            : this(name, GameConstants.Instance.PlayerHitpoints)
        {

        }

        public ComputerWizard(string name, int health)
        {
            CharacterClass = "Archer";
            attackBehavior = new BowAttack();
            Name = name;
            Health = health;
        }
    }
}
