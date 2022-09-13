using RimWorld;
using System.Collections.Generic;
using UnityEngine;
using Verse;

namespace GachaMod.Characters
{
    public class Xingqiu : Character
    {
        public override Pawn Make()
        {
            return GrantFulfiller.FulfillCharacter
            (
                "Xingqiu",
                "Guhua",
                "Heir",
                17f,
                Gender.Male,
                0f,
                null,
                null,
                "Fringe",
                new Color(0.1f, 0.6f, 0.7f),
                "bookworm",
                null,
                new List<Trait>
                {
                    new Trait(TraitDefOf.Kind),
                    new Trait(TraitDefOf.Ascetic),
                    new Trait(TraitDef.Named("Nimble"))
                },
                new List<Skill>
                {
                    new Skill(SkillDefOf.Melee, Passion.Major, 6),
                    new Skill(SkillDefOf.Artistic, Passion.Major, 5),
                    new Skill(SkillDefOf.Intellectual, Passion.Major, 6)
                },
                6
            );
        }
    }
}
