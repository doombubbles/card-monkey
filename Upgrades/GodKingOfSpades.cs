﻿using Il2CppAssets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Towers;

namespace CardMonkey.Upgrades;

public class GodKingOfSpades : ModParagonUpgrade<CardMonkey>
{
    public override int Cost => 400000;
    public override string Description => "Sometimes the hand of fate must be forced...";
    public override string DisplayName => "God-King of Spades";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // Using 555 mode so not much has to be done here if you don't want to
    }
}