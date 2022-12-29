using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Unity.Display;
using BTD_Mod_Helper.Api.Display;
using BTD_Mod_Helper.Extensions;
using UnityEngine;

namespace CardMonkey.Displays.Tier5
{
    public class RoyalFlushDisplay : ModTowerDisplay<CardMonkey>
    {
        public override string BaseDisplay => GetDisplay(TowerType.Alchemist, 0, 0, 5);

        public override bool UseForTower(int[] tiers)
        {
            return tiers[0] == 5;
        }

        public override void ModifyDisplayNode(UnityDisplayNode node)
        {
# if DEBUG
            node.SaveMeshTexture(0);
            node.SaveMeshTexture(1);
            node.PrintInfo();
#endif

            // Remove the potion in hand
            node.RemoveBone("AlchemistRig:Propjectile_R");

            // PrintInfo() showed this has multiple SkinnedMeshRenderers, so have to specify the index
            SetMeshTexture(node, "RoyalFlushDisplay", 0);
            SetMeshOutlineColor(node, new Color(73f / 255, 175f / 255, 52f / 255), 0);
            SetMeshTexture(node, "RoyalFlushDisplay", 1);
            SetMeshOutlineColor(node, new Color(73f / 255, 175f / 255, 52f / 255), 1);
        }
    }
}