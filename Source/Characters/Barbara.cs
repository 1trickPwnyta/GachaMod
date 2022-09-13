using RimWorld;
using System.Collections.Generic;
using UnityEngine;
using Verse;

namespace GachaMod.Characters
{
    public class Barbara : Character
    {
        public override Pawn Make()
        {
            return GrantFulfiller.FulfillCharacter
            (
                "Barbara",
                "Pegg",
                "Deaconess",
                16f,
                Gender.Female,
                0f,
                "Barbara_uniform",
                "Barbara_headgear",
                "Barbara",
                new Color(1f, 1f, 1f),
                "vidtube star",
                null,
                new List<Trait>
                {
                    new Trait(TraitDefOf.Kind),
                    new Trait(TraitDefOf.Ascetic),
                    new Trait(TraitDefOf.NaturalMood, -2)
                },
                new List<Skill>
                {
                    new Skill(SkillDefOf.Shooting, Passion.Minor, 3),
                    new Skill(SkillDefOf.Artistic, Passion.Major, 6),
                    new Skill(SkillDefOf.Medicine, Passion.Major, 6),
                    new Skill(SkillDefOf.Social, Passion.Minor, 4)
                },
                6
            );
        }
    }
}
