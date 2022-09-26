using HarmonyLib;
using UnityEngine;
using Verse;

namespace GachaMod
{
    public class GachaMod : Mod
    {
        public const string PACKAGE_ID = "gachamod.1trickPwnyta";
        public const string PACKAGE_NAME = "Gacha Mod";

        public static GachaSettings Settings;

        public GachaMod(ModContentPack content) : base(content)
        {
            Settings = GetSettings<GachaSettings>();

            var harmony = new Harmony(PACKAGE_ID);
            harmony.PatchAll();

            Log.Message($"[{PACKAGE_NAME}] Loaded.");
        }

        public override string SettingsCategory() => PACKAGE_NAME;

        public override void DoSettingsWindowContents(Rect inRect)
        {
            base.DoSettingsWindowContents(inRect);
            GachaSettings.DoSettingsWindowContents(inRect);
        }
    }
}
