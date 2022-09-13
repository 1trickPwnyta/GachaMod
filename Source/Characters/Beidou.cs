using RimWorld;
using System.Collections.Generic;
using UnityEngine;
using Verse;

namespace GachaMod.Characters
{
    public class Beidou : Character
    {
        public override Pawn Make()
        {
            return GrantFulfiller.FulfillCharacter
            (
                "Beidou",
                "Crux",
                "Captain",
                33f,
                Gender.Female,
                0f,
                "Beidou_uniform",
                null,
                "Beidou",
                new Color(1f, 1f, 1f),
                "young pirate",
                "pirate captain",
                new List<Trait>
                {
                    new Trait(TraitDefOf.Brawler),
                    new Trait(TraitDefOf.DrugDesire, 1),
                    new Trait(TraitDefOf.Tough)
                },
                new List<Skill>
                {
                    new Skill(SkillDefOf.Melee, Passion.Major, 6),
                    new Skill(SkillDefOf.Construction, Passion.Minor, 3),
                    new Skill(SkillDefOf.Mining, Passion.Minor, 2),
                    new Skill(SkillDefOf.Social, Passion.Major, 6)
                },
                6
            );
        }
    }
}
