using HarmonyLib;
using RimWorld;
using System.Collections.Generic;
using Verse;

namespace GachaMod
{
    [HarmonyPatch(typeof(Building_CommsConsole))]
    [HarmonyPatch(nameof(Building_CommsConsole.GetCommTargets))]
    public static class Patch_Building_CommsConsole
    {
        public static void Postfix(ref IEnumerable<ICommunicable> __result, Pawn myPawn)
        {
            if (__result != null)
            {
                if (TradeUtility.AmountSendablePrimogem(myPawn.Map) >= 160)
                {
                    List<ICommunicable> list = new List<ICommunicable>();
                    list.Add(new WishCommunicable());
                    list.AddRange(__result);
                    __result = list;
                }
            }
        }
    }
}
