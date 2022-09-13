using RimWorld;
using System.Collections.Generic;
using UnityEngine;
using Verse;

namespace GachaMod.Characters
{
    public class Ningguang : Character
    {
        public override Pawn Make()
        {
            return GrantFulfiller.FulfillCharacter
            (
                "Ningguang",
                "Qixing",
                "Tianquan",
                36f,
                Gender.Female,
                0f,
                "Ningguang_uniform",
                null,
                "Ningguang",
                new Color(1f, 1f, 1f),
                "street urchin",
                "corporate manager",
                new List<Trait>
                {
                    new Trait(TraitDefOf.Greedy),
                    new Trait(TraitDefOf.Industriousness, 2),
                    new Trait(TraitDefOf.Psychopath)
                },
                new List<Skill>
                {
                    new Skill(SkillDefOf.Shooting, Passion.Minor, 4),
                    new Skill(SkillDefOf.Construction, Passion.Minor, 3),
                    new Skill(SkillDefOf.Mining, Passion.Minor, 3),
                    new Skill(SkillDefOf.Social, Passion.Major, 6)
                },
                6
            );
        }
    }
}
