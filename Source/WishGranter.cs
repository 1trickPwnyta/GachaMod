using System;
using System.Collections.Generic;

namespace GachaMod
{
    public static class WishGranter
    {
        private static Random random = new Random();

        public static void GrantWish()
        {
            List<string> possibleGrants = new List<string>();
            if (random.NextDouble() < 0.016)
            {
                possibleGrants.Add("Keqing");
                possibleGrants.Add("Diluc");
                possibleGrants.Add("Qiqi");
                possibleGrants.Add("Mona");
                possibleGrants.Add("Jean");
                possibleGrants.Add("monosword");
                possibleGrants.Add("plasmasword");
                possibleGrants.Add("zeushammer");
                possibleGrants.Add("charge rifle");
                possibleGrants.Add("charge lance");
            } 
            else if (random.NextDouble() < 0.12)
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
                possibleGrants.Add("Razor");
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

            string grant = possibleGrants[random.Next(possibleGrants.Count)];
            Debug.Log("Wish granted: " + grant);
        }
    }
}
