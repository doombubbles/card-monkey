using System.Collections.Generic;
using Assets.Scripts.Models.TowerSets;
using BTD_Mod_Helper.Api.Towers;

namespace CardMonkey
{
    public class Cool : ModTowerSet
    {
        // public override string Button => "Name of .png file for the group button used in the Monkeys menu, by default Name-Button";

        // public override string Container => "Name of .png file for the background for towers in the Monkeys menu and the in game shop, by default Name-Container";

        // public override string ContainerLarge => "Name of .png file for the background used for non-paragon upgrades in the Upgrade screen, by default Name-ContainerLarge";

        // public override string Portrait => "Name of .png file for the background for in game portraits, by default Name-Portrait";

        // public override string DisplayName => "The name that will be actually displayed for the Tower Set in game";

        /// <summary>
        /// Set the ordering of this Tower Set, in this case after Primary.
        /// If this wasn't here, it'd be added at the end after all other tower sets.
        /// </summary>
        /// <param name="towerSets"></param>
        /// <returns></returns>
        public override int GetTowerSetIndex(List<string> towerSets)
        {
            return towerSets.IndexOf("Primary") + 1;
        }

        /// <summary>
        /// If we wanted to customize the exact position within the list of Towers in the shop where this tower set
        /// would begin, we could do that here.
        /// </summary>
        /// <param name="towerSet"></param>
        /// <returns></returns>
        public override int GetTowerStartIndex(List<TowerDetailsModel> towerSet)
        {
            return base.GetTowerStartIndex(towerSet);
        }
    }
}