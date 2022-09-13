using RimWorld;
using System.Collections.Generic;
using UnityEngine;
using Verse;

namespace GachaMod.Characters
{
    public class Mona : Character
    {
        public override Pawn Make()
        {
            return GrantFulfiller.FulfillCharacter
            (
                "Mona",
                "Megistus",
                "Astrologist",
                23f,
                Gender.Female,
                0f,
                "Mona_uniform",
                "Mona_headgear",
                "Mona",
                new Color(1f, 1f, 1f),
                "apprentice oracle",
                "low-wage worker",
                new List<Trait>
                {
                    new Trait(TraitDefOf.PsychicSensitivity, 2),
                    new Trait(TraitDefOf.Ascetic),
                    new Trait(TraitDefOf.GreatMemory)
                },
                new List<Skill>
                {
                    new Skill(SkillDefOf.Shooting, Passion.Minor, 8),
                    new Skill(SkillDefOf.Crafting, Passion.Minor, 6),
                    new Skill(SkillDefOf.Artistic, Passion.Major, 10),
                    new Skill(SkillDefOf.Intellectual, Passion.Major, 12)
                },
                -1
            );
        }
    }
}
