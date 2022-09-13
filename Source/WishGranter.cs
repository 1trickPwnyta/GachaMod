using GachaMod.Characters;
using RimWorld;
using System;
using System.Collections.Generic;
using UnityEngine;
using Verse;
using Verse.Sound;

namespace GachaMod
{
    public static class WishGranter
    {
        public static void GrantWish(Map map)
        {
            string grant = GrantGenerator.GetGrant();
            grant = "Mona";
            Debug.Log("Wish granted: " + grant);

            List<Thing> list = new List<Thing>();
            switch (grant)
            {
                case "EMP grenades":
                    list.Add(GrantFulfiller.FulfillThing("Weapon_GrenadeEMP", null, QualityCategory.Excellent));
                    break;
                case "molotov cocktails":
                    list.Add(GrantFulfiller.FulfillThing("Weapon_GrenadeMolotov", null, QualityCategory.Excellent));
                    break;
                case "frag grenades":
                    list.Add(GrantFulfiller.FulfillThing("Weapon_GrenadeFrag", null, QualityCategory.Excellent));
                    break;
                case "bolt-action rifle":
                    list.Add(GrantFulfiller.FulfillThing("Gun_BoltActionRifle", null, QualityCategory.Excellent));
                    break;
                case "pump shotgun":
                    list.Add(GrantFulfiller.FulfillThing("Gun_PumpShotgun", null, QualityCategory.Excellent));
                    break;
                case "machine pistol":
                    list.Add(GrantFulfiller.FulfillThing("Gun_MachinePistol", null, QualityCategory.Excellent));
                    break;
                case "autopistol":
                    list.Add(GrantFulfiller.FulfillThing("Gun_Autopistol", null, QualityCategory.Excellent));
                    break;
                case "revolver":
                    list.Add(GrantFulfiller.FulfillThing("Gun_Revolver", null, QualityCategory.Excellent));
                    break;
                case "greatbow":
                    list.Add(GrantFulfiller.FulfillThing("Bow_Great", null, QualityCategory.Excellent));
                    break;
                case "recurve bow":
                    list.Add(GrantFulfiller.FulfillThing("Bow_Recurve", null, QualityCategory.Excellent));
                    break;
                case "shortbow":
                    list.Add(GrantFulfiller.FulfillThing("Bow_Short", null, QualityCategory.Excellent));
                    break;
                case "pila":
                    list.Add(GrantFulfiller.FulfillThing("Pila", null, QualityCategory.Excellent));
                    break;
                case "club":
                    list.Add(GrantFulfiller.FulfillThing("MeleeWeapon_Club", ThingDefOf.Plasteel, QualityCategory.Excellent));
                    break;
                case "gladius":
                    list.Add(GrantFulfiller.FulfillThing("MeleeWeapon_Gladius", ThingDefOf.Plasteel, QualityCategory.Excellent));
                    break;
                case "breach axe":
                    list.Add(GrantFulfiller.FulfillThing("MeleeWeapon_BreachAxe", ThingDefOf.Plasteel, QualityCategory.Excellent));
                    break;
                case "axe":
                    list.Add(GrantFulfiller.FulfillThing("MeleeWeapon_Axe", ThingDefOf.Plasteel, QualityCategory.Excellent));
                    break;
                case "ikwa":
                    list.Add(GrantFulfiller.FulfillThing("MeleeWeapon_Ikwa", ThingDefOf.Plasteel, QualityCategory.Excellent));
                    break;
                case "knife":
                    list.Add(GrantFulfiller.FulfillThing("MeleeWeapon_Knife", ThingDefOf.Plasteel, QualityCategory.Excellent));
                    break;
                case "incendiary launcher":
                    list.Add(GrantFulfiller.FulfillThing("Gun_IncendiaryLauncher", null, QualityCategory.Masterwork));
                    break;
                case "EMP launcher":
                    list.Add(GrantFulfiller.FulfillThing("Gun_EmpLauncher", null, QualityCategory.Masterwork));
                    break;
                case "smoke launcher":
                    list.Add(GrantFulfiller.FulfillThing("Gun_SmokeLauncher", null, QualityCategory.Masterwork));
                    break;
                case "warhammer":
                    list.Add(GrantFulfiller.FulfillThing("MeleeWeapon_Warhammer", ThingDefOf.Plasteel, QualityCategory.Masterwork));
                    break;
                case "spear":
                    list.Add(GrantFulfiller.FulfillThing("MeleeWeapon_Spear", ThingDefOf.Plasteel, QualityCategory.Masterwork));
                    break;
                case "longsword":
                    list.Add(GrantFulfiller.FulfillThing("MeleeWeapon_LongSword", ThingDefOf.Plasteel, QualityCategory.Masterwork));
                    break;
                case "mace":
                    list.Add(GrantFulfiller.FulfillThing("MeleeWeapon_Mace", ThingDefOf.Uranium, QualityCategory.Masterwork));
                    break;
                case "chain shotgun":
                    list.Add(GrantFulfiller.FulfillThing("Gun_ChainShotgun", null, QualityCategory.Masterwork));
                    break;
                case "LMG":
                    list.Add(GrantFulfiller.FulfillThing("Gun_LMG", null, QualityCategory.Masterwork));
                    break;
                case "heavy SMG":
                    list.Add(GrantFulfiller.FulfillThing("Gun_HeavySMG", null, QualityCategory.Masterwork));
                    break;
                case "minigun":
                    list.Add(GrantFulfiller.FulfillThing("Gun_Minigun", null, QualityCategory.Masterwork));
                    break;
                case "sniper rifle":
                    list.Add(GrantFulfiller.FulfillThing("Gun_SniperRifle", null, QualityCategory.Masterwork));
                    break;
                case "assault rifle":
                    list.Add(GrantFulfiller.FulfillThing("Gun_AssaultRifle", null, QualityCategory.Masterwork));
                    break;
                case "charge lance":
                    list.Add(GrantFulfiller.FulfillThing("Gun_ChargeLance", null, QualityCategory.Legendary));
                    break;
                case "charge rifle":
                    list.Add(GrantFulfiller.FulfillThing("Gun_ChargeRifle", null, QualityCategory.Legendary));
                    break;
                case "monosword":
                    list.Add(GrantFulfiller.FulfillThing("MeleeWeapon_MonoSword", null, QualityCategory.Legendary));
                    break;
                case "plasmasword":
                    list.Add(GrantFulfiller.FulfillThing("MeleeWeapon_PlasmaSword", null, QualityCategory.Legendary));
                    break;
                case "zeushammer":
                    list.Add(GrantFulfiller.FulfillThing("MeleeWeapon_Zeushammer", null, QualityCategory.Legendary));
                    break;
                case "Amber":
                    list.Add((new Amber()).Make());
                    break;
                case "Kaeya":
                    list.Add((new Kaeya()).Make());
                    break;
                case "Lisa":
                    list.Add((new Lisa()).Make());
                    break;
                case "Noelle":
                    list.Add((new Noelle()).Make());
                    break;
                case "Barbara":
                    list.Add((new Barbara()).Make());
                    break;
                case "Beidou":
                    list.Add((new Beidou()).Make());
                    break;
                case "Ningguang":
                    list.Add((new Ningguang()).Make());
                    break;
                case "Xingqiu":
                    list.Add((new Xingqiu()).Make());
                    break;
                case "Bennett":
                    list.Add((new Bennett()).Make());
                    break;
                case "Chongyun":
                    list.Add((new Chongyun()).Make());
                    break;
                case "Xiangling":
                    list.Add((new Xiangling()).Make());
                    break;
                case "Keqing":
                    list.Add((new Keqing()).Make());
                    break;
                case "Diluc":
                    list.Add((new Diluc()).Make());
                    break;
                case "Qiqi":
                    list.Add((new Qiqi()).Make());
                    break;
                case "Mona":
                    list.Add((new Mona()).Make());
                    break;
                case "Jean":
                    list.Add((new Jean()).Make());
                    break;
            }

            IntVec3 position = DropCellFinder.TradeDropSpot(map);
            DropPodUtility.DropThingsNear(position, map, list, 110, false, false, false, false);
            SoundDef.Named("Wish").PlayOneShot(SoundInfo.InMap(new TargetInfo(position, map, false), MaintenanceType.None));

            Timer.Set(delegate ()
            {
                Find.LetterStack.ReceiveLetter
                (
                    "GachaMod_WishGrantedLetterLabel".Translate(grant),
                    "GachaMod_WishGrantedLetterText".Translate(grant),
                    LetterDefOf.PositiveEvent, 
                    list.FirstOrFallback(null)
                );
            }, 8000);
        }
    }
}
