using RimWorld;
using System.Collections.Generic;
using UnityEngine;
using Verse;

namespace GachaMod.Characters
{
    public class Diluc : Character
    {
        public override Pawn Make()
        {
            return GrantFulfiller.FulfillCharacter
            (
                "Diluc",
                "Ragnvindr",
                "Winery owner",
                35f,
                Gender.Male,
                0f,
                "Diluc_uniform",
                null,
                "Diluc",
                new Color(1f, 1f, 1f),
                "farm boy",
                "bartender",
                new List<Trait>
                {
                    new Trait(TraitDefOf.DrugDesire, -1),
                    new Trait(TraitDef.Named("NightOwl")),
                    new Trait(TraitDefOf.Nerves, 1)
                },
                new List<Skill>
                {
                    new Skill(SkillDefOf.Melee, Passion.Major, 12),
                    new Skill(SkillDefOf.Cooking, Passion.Major, 9),
                    new Skill(SkillDefOf.Plants, Passion.Major, 10),
                    new Skill(SkillDefOf.Intellectual, Passion.Minor, 6)
                },
                -1
            );
        }
    }
}
