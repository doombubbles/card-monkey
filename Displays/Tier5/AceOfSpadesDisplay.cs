using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Unity.Display;
using BTD_Mod_Helper.Api.Display;
using BTD_Mod_Helper.Extensions;
using UnityEngine;

namespace CardMonkey.Displays.Tier5
{
    public class AceOfSpadesDisplay : ModTowerDisplay<CardMonkey>
    {
        public override string BaseDisplay => GetDisplay(TowerType.BoomerangMonkey, 5);

        public override bool UseForTower(int[] tiers)
        {
            return tiers[1] == 5;
        }

        public override void ModifyDisplayNode(UnityDisplayNode node)
        {
# if DEBUG
            node.SaveMeshTexture(1);
            node.SaveMeshTexture(2);
            node.SaveMeshTexture();
            node.PrintInfo();
#endif

            node.RemoveBone("SuperMonkeyRig:Dart");

            // PrintInfo() showed this has multiple SkinnedMeshRenderers, so have to specify the index
            SetMeshTexture(node, "AceOfSpadesCape", 1);
            SetMeshOutlineColor(node, new Color(0, 0, 0), 1);
            SetMeshTexture(node, "AceOfSpadesDisplay", 2);
            SetMeshOutlineColor(node, new Color(0, 0, 0), 2);
        }
    }
}