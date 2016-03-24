/*
 *  Created by Kee Sern on 3/24/16.
 *  Copyright © 2016 Kee Sern. All rights reserved.
*/

using System;
using System.Collections.Generic;
using Kee.RoleplayingGameInterfaces;

namespace Kee.RPGCore
{
    public class Program
    {
        static void Main(string[] args)
        {
            IList<ICharacter> playerParty = new List<ICharacter>();
            IList<ICharacter> enemyParty = new List<ICharacter>();

            playerParty.Add(new Mage());
            playerParty.Add(new Warrior());

            enemyParty.Add(new Archer());
            enemyParty.Add(new ComputerWizard());

            var combat = new Combat(playerParty, enemyParty, "Players", "Enemies");
            combat.AutoBattle();

            Console.ReadLine();
        }
    }
}
