using HarmonyLib;
using RimWorld;
using System;
using Verse;

namespace GachaMod
{
    [HarmonyPatch(typeof(PawnGenerator))]
    [HarmonyPatch(nameof(PawnGenerator.GeneratePawn))]
    [HarmonyPatch(new[] { typeof(PawnGenerationRequest) })]
    public static class Patch_PawnGenerator
    {
        private static Random random = new Random();

        public static void Postfix(ref Pawn __result)
        {
            if (__result != null && __result.inventory != null && !__result.NonHumanlikeOrWildMan())
            {
                int num = random.Next(10);
                for (int i = 0; i < num + 3; i++)
                {
                    __result.inventory.TryAddAndUnforbid(new ThingStuffPairWithQuality(ThingDef.Named("Primogem"), null, QualityCategory.Normal).MakeThing());
                }
            }
        }
    }
}
