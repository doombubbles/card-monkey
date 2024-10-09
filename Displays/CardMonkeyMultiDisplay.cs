﻿using System.Collections.Generic;
using System.Linq;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Unity.Display;
using BTD_Mod_Helper.Api;
using BTD_Mod_Helper.Api.Display;
using BTD_Mod_Helper.Extensions;
using UnityEngine;

namespace CardMonkey.Displays
{
    /// <summary>
    /// This is a more complicated example of a ModTowerDisplay, one that loads multiple versions of itself that are
    /// slightly different in order to take advantage of many Boomerang Monkey variants all using the same sprite sheet
    /// </summary>
    public class CardMonkeyMultiDisplay : ModTowerDisplay<CardMonkey>
    {
        private readonly int[] t = null!; // The tiers used for a particular instance of CardMonkeyBaseDisplay

        /// <summary>
        /// All classes that derive from ModContent MUST have a zero argument constructor to work
        /// </summary>
        public CardMonkeyMultiDisplay()
        {
        }

        public CardMonkeyMultiDisplay(int[] tiers)
        {
            t = tiers;
        }

        /* Using the t value for various overrides */

        // Have to give each Display a different name based on the tiers
        public override string Name => nameof(CardMonkeyMultiDisplay) + "-" + t.Printed();

        // Copy the corresponding Boomerang Monkey display
        public override string BaseDisplay => GetDisplay(TowerType.BoomerangMonkey, t[0], t[1], t[2]);

        /// <summary>
        /// This is an example of loading multiple instances of the same ModDisplay with different values
        /// </summary>
        public override IEnumerable<ModContent> Load()
        {
            for (var i = 0; i <= 2; i++)
            {
                for (var j = 0; j <= 2; j++)
                {
                    for (var k = 0; k <= 2; k++)
                    {
                        var tiers = new[] {i, j, k};
                        if (tiers.IsValid())
                        {
                            yield return new CardMonkeyMultiDisplay(tiers);
                        }
                    }
                }
            }
        }

        public override bool UseForTower(int[] tiers)
        {
            if (t.Sum() == 0) // Temporarily use the base display for all tier 3-4 crosspaths
            {
                return tiers.Max() < 5;
            }

            return false; //tiers.SequenceEqual(t);
        }

        /// <summary>
        /// All the different nodes can be modified in the same way
        /// </summary>
        public override void ModifyDisplayNode(UnityDisplayNode node)
        {
# if DEBUG
            // Print info about the node in order to edit it easier
            node.PrintInfo();
            node.SaveMeshTexture();
#endif

            // Always set the MeshTexture to the same one, since all the cross-paths use the same original sprite atlas
            // SetMeshTexture(node, nameof(CardMonkeyBaseDisplay));
            
            node.GetRenderer("FlatSkin").AdjustHSV(56, .3f, .9f, new Color(255 / 255f, 244 / 255f, 0 / 255f), .4f);

            SetMeshOutlineColor(node, new Color(73f / 255, 175f / 255, 52f / 255));


            // Make it not hold the Boomerang, name found through the PrintInfo() method above
            node.RemoveBone("SuperMonkeyRig:Dart");
        }
    }
}