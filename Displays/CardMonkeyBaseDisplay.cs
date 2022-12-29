using System.Linq;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Unity.Display;
using BTD_Mod_Helper.Api.Display;
using BTD_Mod_Helper.Extensions;
using UnityEngine;

namespace CardMonkey.Displays
{
    public class CardMonkeyBaseDisplay : ModTowerDisplay<CardMonkey>
    {
        // Copy the Boomerang Monkey display
        public override string BaseDisplay => GetDisplay(TowerType.BoomerangMonkey);

        public override bool UseForTower(int[] tiers)
        {
            return tiers.Sum() == 0;
        }

        public override void ModifyDisplayNode(UnityDisplayNode node)
        {
            // Print info about the node in order to edit it easier
# if DEBUG
            node.PrintInfo();
            node.SaveMeshTexture();
#endif

            // Set our custom texture
            SetMeshTexture(node, Name);
            SetMeshOutlineColor(node, new Color(73f / 255, 175f / 255, 52f / 255));

            // Make it not hold the Boomerang
            node.RemoveBone("SuperMonkeyRig:Dart");
        }
    }
}