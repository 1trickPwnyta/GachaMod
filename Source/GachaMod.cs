using HarmonyLib;
using Verse;

namespace GachaMod
{
    public class GachaMod : Mod
    {
        public const string PACKAGE_ID = "gachamod.1trickPwnyta";
        public const string PACKAGE_NAME = "Gacha Mod";

        public GachaMod(ModContentPack content) : base(content)
        {
            var harmony = new Harmony(PACKAGE_ID);
            harmony.PatchAll();

            Log.Message($"[{PACKAGE_NAME}] Loaded.");
        }
    }
}
