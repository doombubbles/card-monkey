using BTD_Mod_Helper;
using MelonLoader;

[assembly: MelonInfo(typeof(CardMonkey.Main), "Card Monkey", "0.2.1", "doombubbles")]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace CardMonkey
{
    public class Main : BloonsTD6Mod
    {
        public override string MelonInfoCsURL =>
            "https://raw.githubusercontent.com/doombubbles/card-monkey/main/Main.cs";

        public override string LatestURL =>
            "https://github.com/doombubbles/card-monkey/blob/main/CardMonkey.dll?raw=true";

        // No Harmony Patches or hooks required for this whole tower!
    }
}