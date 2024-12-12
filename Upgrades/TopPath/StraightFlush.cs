﻿using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Emissions;
using Il2CppAssets.Scripts.Models.Towers.Weapons.Behaviors;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;

namespace CardMonkey.Upgrades.TopPath;

public class StraightFlush : ModUpgrade<CardMonkey>
{
    public override int Path => TOP;
    public override int Tier => 4;
    public override int Cost => 4000;
    public override int Priority => -1;

    public override string Description => "Throws 5 cards at a time. Cards do 1, 2, 3, 4 and 5 damage.";

    public override string Portrait => "CardMonkey-Portrait";

    public override void ApplyUpgrade(TowerModel tower)
    {
        foreach (var weaponModel in tower.GetWeapons())
        {
            weaponModel.emission = new EmissionWithOffsetsModel("EmissionWithOffsetsModel_", new[]
            {
                new ThrowMarkerOffsetModel("ThrowMarkerOffsetModel_", -4, 0, 0, 0)
            }, 1, false, null, 0);


            for (var i = 1; i <= 4; i++)
            {
                var newWeapon = weaponModel.Duplicate();
                newWeapon.projectile.GetDamageModel().damage += i;
                newWeapon.emission.Cast<EmissionWithOffsetsModel>().throwMarkerOffsetModels[0].ejectX += i * 2;
                tower.GetAttackModel().AddWeapon(newWeapon);
            }
        }
    }
}