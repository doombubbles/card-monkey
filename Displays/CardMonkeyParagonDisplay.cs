using System.Collections.Generic;
using Assets.Scripts.Models.GenericBehaviors;
using Assets.Scripts.Models.Towers;
using Assets.Scripts.Unity;
using Assets.Scripts.Unity.Display;
using BTD_Mod_Helper.Api;
using BTD_Mod_Helper.Api.Display;
using BTD_Mod_Helper.Extensions;

namespace CardMonkey.Displays
{
    public class CardMonkeyParagonDisplay : ModTowerDisplay<CardMonkey>
    {
        public override float Scale => .75f + ParagonDisplayIndex * .025f;

        public override string BaseDisplay =>
            Game.instance.model.GetTower(TowerType.SuperMonkey, 5).GetAttackModel().GetBehavior<DisplayModel>().display;

        public override bool UseForTower(int[] tiers)
        {
            return IsParagon(tiers);
        }

        /// <summary>
        /// All classes that derive from ModContent MUST have a zero argument constructor to work
        /// </summary>
        public CardMonkeyParagonDisplay()
        {
        }

        public CardMonkeyParagonDisplay(int i)
        {
            ParagonDisplayIndex = i;
        }

        public override int ParagonDisplayIndex { get; }

        /// <summary>
        /// Create a display for each possible ParagonDisplayIndex
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<ModContent> Load()
        {
            for (var i = 0; i < TotalParagonDisplays; i++)
            {
                yield return new CardMonkeyParagonDisplay(i);
            }
        }

        public override string Name => nameof(CardMonkeyParagonDisplay) + ParagonDisplayIndex;

        /// <summary>
        /// Could use the ParagonDisplayIndex property to use different effects based on the paragon strength
        /// <see cref="ModTowerDisplay.ParagonDisplayIndex"/>
        /// </summary>
        /// <param name="node"></param>
        public override void ModifyDisplayNode(UnityDisplayNode node)
        {
            //node.PrintInfo();
            //node.SaveMeshTexture();

            SetMeshTexture(node, nameof(CardMonkeyParagonDisplay));
        }
    }
}