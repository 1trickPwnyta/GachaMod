using System.Linq;
using Verse;

namespace GachaMod
{
    public static class TradeUtility
    {
        public static int AmountSendablePrimogem(Map map)
        {
            return (from t in RimWorld.TradeUtility.AllLaunchableThingsForTrade(map, null)
                    where t.def == ThingDefOf.Primogem
                    select t).Sum((Thing t) => t.stackCount);
        }
    }
}
