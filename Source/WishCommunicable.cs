using RimWorld;
using System.Linq;
using Verse;

namespace GachaMod
{
    public class WishCommunicable : ICommunicable
    {
        public FloatMenuOption CommFloatMenuOption(Building_CommsConsole console, Pawn negotiator)
        {
            return new FloatMenuOption(
                "GachaMod_MakeAWish".Translate(),
                delegate ()
                {
                    if (!Building_OrbitalTradeBeacon.AllPowered(console.Map).Any<Building_OrbitalTradeBeacon>())
                    {
                        Messages.Message("GachaMod_MessageNeedBeaconToWish".Translate(), console, MessageTypeDefOf.RejectInput, false);
                        return;
                    }
                    console.GiveUseCommsJob(negotiator, this);
                }
            );
        }

        public string GetCallLabel()
        {
            return "GachaMod_MakeAWish".Translate();
        }

        public Faction GetFaction()
        {
            return null;
        }

        public string GetInfoText()
        {
            return "GachaMod_MakeAWish".Translate();
        }

        public void TryOpenComms(Pawn negotiator)
        {
            if (TradeUtility.AmountSendablePrimogem(negotiator.Map) >= 160)
            {
                WishGranter.GrantWish();
                RimWorld.TradeUtility.LaunchThingsOfType(ThingDefOf.Primogem, 160, negotiator.Map, null);
            }
        }
    }
}
