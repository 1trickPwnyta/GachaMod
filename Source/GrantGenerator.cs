using System;
using System.Collections.Generic;
using Verse;

namespace GachaMod
{
    public static class GrantGenerator
    {
        public static string GetGrant()
        {
            List<string> possibleGrants = new List<string>();
            if (Rand.Value < 0.016f)
            {
                possibleGrants.Add("Keqing");
                possibleGrants.Add("Diluc");
                possibleGrants.Add("Qiqi");
                possibleGrants.Add("Mona");
                possibleGrants.Add("Jean");
                if (ModsConfig.RoyaltyActive)
                {
                    possibleGrants.Add("monosword");
                    possibleGrants.Add("plasmasword");
                    possibleGrants.Add("zeushammer");
                }
                possibleGrants.Add("charge rifle");
                possibleGrants.Add("charge lance");
            }
            else if (Rand.Value < 0.12)
            {
                possibleGrants.Add("Amber");
                possibleGrants.Add("Kaeya");
                possibleGrants.Add("Lisa");
                possibleGrants.Add("Noelle");
                possibleGrants.Add("Barbara");
                possibleGrants.Add("Beidou");
                possibleGrants.Add("Ningguang");
                possibleGrants.Add("Xingqiu");
                possibleGrants.Add("Bennett");
                possibleGrants.Add("Chongyun");
                possibleGrants.Add("Xiangling");
                possibleGrants.Add("assault rifle");
                possibleGrants.Add("sniper rifle");
                possibleGrants.Add("minigun");
                possibleGrants.Add("heavy SMG");
                possibleGrants.Add("LMG");
                possibleGrants.Add("chain shotgun");
                possibleGrants.Add("mace");
                possibleGrants.Add("longsword");
                possibleGrants.Add("spear");
                possibleGrants.Add("warhammer");
                possibleGrants.Add("smoke launcher");
                possibleGrants.Add("EMP launcher");
                possibleGrants.Add("incendiary launcher");
            }
            else
            {
                possibleGrants.Add("knife");
                possibleGrants.Add("ikwa");
                possibleGrants.Add("axe");
                possibleGrants.Add("breach axe");
                possibleGrants.Add("gladius");
                possibleGrants.Add("club");
                possibleGrants.Add("pila");
                possibleGrants.Add("shortbow");
                possibleGrants.Add("recurve bow");
                possibleGrants.Add("greatbow");
                possibleGrants.Add("revolver");
                possibleGrants.Add("autopistol");
                possibleGrants.Add("machine pistol");
                possibleGrants.Add("pump shotgun");
                possibleGrants.Add("bolt-action rifle");
                possibleGrants.Add("frag grenades");
                possibleGrants.Add("molotov cocktails");
                possibleGrants.Add("EMP grenades");
            }

            string grant = possibleGrants[Rand.Range(0, possibleGrants.Count)];
            return grant;
        }
    }
}
