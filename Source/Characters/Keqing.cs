using RimWorld;
using System.Collections.Generic;
using UnityEngine;
using Verse;

namespace GachaMod.Characters
{
    public class Keqing : Character
    {
        public override Pawn Make()
        {
            return GrantFulfiller.FulfillCharacter
            (
                "Keqing",
                "Qixing",
                "Yuheng",
                27f,
                Gender.Female,
                0f,
                "Keqing_uniform",
                "Keqing_headgear",
                "Keqing",
                new Color(1f, 1f, 1f),
                "urbword child",
                "civil servant",
                new List<Trait>
                {
                    new Trait(TraitDefOf.Industriousness, 2),
                    new Trait(TraitDefOf.Abrasive),
                    new Trait(TraitDef.Named("Nimble"))
                },
                new List<Skill>
                {
                    new Skill(SkillDefOf.Melee, Passion.Major, 12),
                    new Skill(SkillDefOf.Construction, Passion.Minor, 8),
                    new Skill(SkillDefOf.Intellectual, Passion.Minor, 8),
                    new Skill(SkillDefOf.Mining, Passion.Minor, 6)
                },
                -1
            );
        }
    }
}
