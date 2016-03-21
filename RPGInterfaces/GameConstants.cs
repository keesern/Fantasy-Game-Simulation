namespace Kee.RoleplayingGameInterfaces
{
    public class GameConstants
    {
        private static GameConstants instance = new GameConstants();
        private const int dodgeDifficulty = 5; // Chance is 1/DodgeDifficulty, so increasing numbers are more difficult.
        private const int damageBonus = 5;
        private const int damageRange = 10;
        private const int playerHitpoints = 50;
                        
        public static GameConstants Instance
        {
            get { return instance; }
        }

        public int DodgeDifficulty
        {
            get { return dodgeDifficulty; }
        }

        public int DamageBonus
        {
            get { return damageBonus; }
        }

        public int DamageRange
        {
            get { return damageRange; }
        }

        public int PlayerHitpoints
        {
            get { return playerHitpoints; }
        } 

        private GameConstants()
        {
            
        }
    }
}
