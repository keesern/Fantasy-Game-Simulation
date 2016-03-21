using Kee.RoleplayingGameInterfaces;

namespace Kee.RPGCore
{
    public interface ICombat
    {
        /// <summary>
        /// Perform a battle between the two groups until one is defeated.
        /// </summary>
        void AutoBattle();

        void GenerateCombatantsList();
        void RandomizeCombatOrder();
        void SwapCombatants(int i, int j);
        bool CombatOver();
        int NumLiving(int groupIndex);
        bool GroupDead(int groupIndex);
        void DoNextTurn();
        void FindNextLivingCombatant();
        ICharacter ChooseRandomLivingTarget(int groupIndex);
        void DisplayBattleState();
    }
}
