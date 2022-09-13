using RimWorld;
using System.Collections.Generic;
using UnityEngine;
using Verse;

namespace GachaMod.Characters
{
    public class Lisa : Character
    {
        public override Pawn Make()
        {
            return GrantFulfiller.FulfillCharacter(
                "Lisa",
                "Minci",
                "Librarian",
                29f,
                Gender.Female,
                0f,
                "Lisa_uniform",
                "Lisa_headgear",
                "Lisa",
                new Color(1f, 1f, 1f),
                "bookworm",
                "space researcher",
                new List<Trait>
                {
                    new Trait(TraitDefOf.Industriousness, -2),
                    new Trait(TraitDefOf.GreatMemory),
                    new Trait(TraitDefOf.Beauty, 1)
                },
                new List<Skill>
                {
                    new Skill(SkillDefOf.Shooting, Passion.Minor, 4),
                    new Skill(SkillDefOf.Plants, Passion.Major, 6),
                    new Skill(SkillDefOf.Social, Passion.None, 6),
                    new Skill(SkillDefOf.Intellectual, Passion.Major, 6)
                },
                6
            );
        }
    }
}
