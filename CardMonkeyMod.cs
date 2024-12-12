using BTD_Mod_Helper;
using BTD_Mod_Helper.Api;
using BTD_Mod_Helper.Api.ModOptions;
using CardMonkey;
using Il2CppAssets.Scripts.Unity.UI_New.InGame;
using MelonLoader;
using UnityEngine;

[assembly: MelonInfo(typeof(CardMonkeyMod), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace CardMonkey;

public class CardMonkeyMod : BloonsTD6Mod
{
    public static readonly ModSettingHotkey CardMonkeyHotkey = new(KeyCode.W, HotkeyModifier.Shift)
    {
        icon = ModContent.GetTextureGUID<CardMonkeyMod>("CardMonkey-Icon"),
    };
        
    // No Harmony Patches or hooks required for this whole tower!

}