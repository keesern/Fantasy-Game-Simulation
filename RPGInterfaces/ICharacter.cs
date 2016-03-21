namespace Kee.RoleplayingGameInterfaces
{
    public interface ICharacter
    {
        // Properties
        string CharacterClass { get; }
        string Name { get; }
        int Health { get; }

        // Method
        void PerformAttack(ICharacter target);
        void ReceiveAttact(int damage);
    }
}