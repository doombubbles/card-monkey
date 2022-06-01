using BTD_Mod_Helper;
using CardMonkey;
using MelonLoader;

[assembly: MelonInfo(typeof(CardMonkeyMod), "Card Monkey", "0.2.1", "doombubbles")]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace CardMonkey
{
    public class CardMonkeyMod : BloonsTD6Mod
    {
        // No Harmony Patches or hooks required for this whole tower!
    }
}