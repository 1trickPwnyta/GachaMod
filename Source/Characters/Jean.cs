using RimWorld;
using System.Collections.Generic;
using UnityEngine;
using Verse;

namespace GachaMod.Characters
{
    public class Jean : Character
    {
        public override Pawn Make()
        {
            return GrantFulfiller.FulfillCharacter
            (
                "Jean",
                "Gunnhildr",
                "Ac. Grand Master",
                32f,
                Gender.Female,
                0f,
                "Jean_uniform",
                null,
                "Jean",
                new Color(1f, 1f, 1f),
                "colony kid",
                "pious soldier",
                new List<Trait>
                {
                    new Trait(TraitDefOf.Industriousness, 1),
                    new Trait(TraitDefOf.TooSmart),
                    new Trait(TraitDef.Named("Nimble"))
                },
                new List<Skill>
                {
                    new Skill(SkillDefOf.Melee, Passion.Major, 12),
                    new Skill(SkillDefOf.Cooking, Passion.Minor, 6),
                    new Skill(SkillDefOf.Medicine, Passion.Major, 10),
                    new Skill(SkillDefOf.Social, Passion.Major, 12)
                },
                -1
            );
        }
    }
}
