using UnityEngine;
using Verse;

namespace GachaMod
{
    public class GachaSettings : ModSettings
    {
        public static int FourStarPity = 0;
        public static int FiveStarPity = 0;

        public static void DoSettingsWindowContents(Rect inRect)
        {
            Listing_Standard listingStandard = new Listing_Standard();

            listingStandard.Begin(inRect);

            listingStandard.Label("GachaMod_FourStarPity".Translate(FourStarPity));
            listingStandard.Label("GachaMod_FiveStarPity".Translate(FiveStarPity));

            listingStandard.End();
        }

        public override void ExposeData()
        {
            Scribe_Values.Look(ref FourStarPity, "FourStarPity");
            Scribe_Values.Look(ref FiveStarPity, "FiveStarPity");
        }
    }
}
