using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Unity.Display;
using BTD_Mod_Helper.Api.Display;
using BTD_Mod_Helper.Extensions;
using UnityEngine;

namespace CardMonkey.Displays.Tier5
{
    public class TFDisplay : ModTowerDisplay<CardMonkey>
    {
        public override string BaseDisplay => GetDisplay(TowerType.BoomerangMonkey, 0, 0, 4);

        public override float Scale => 1.15f;

        public override bool UseForTower(int[] tiers)
        {
            return tiers[2] == 5;
        }

        public override void ModifyDisplayNode(UnityDisplayNode node)
        {
#if DEBUG
            node.SaveMeshTexture(1); // used this to get the texture to edit
            node.PrintInfo(); // used this to get the bone names and other info
#endif

            node.RemoveBone("SuperMonkeyRig:Dart");

            SetMeshTexture(node, Name, 1);
            SetMeshOutlineColor(node, new Color(73f / 255, 175f / 255, 52f / 255), 1);
        }
    }
}