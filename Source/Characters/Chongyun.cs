using RimWorld;
using System.Collections.Generic;
using UnityEngine;
using Verse;

namespace GachaMod.Characters
{
    public class Chongyun : Character
    {
        public override Pawn Make()
        {
            return GrantFulfiller.FulfillCharacter
            (
                "Chongyun",
                "Tianheng",
                "Exorcist",
                18f,
                Gender.Male,
                0f,
                null,
                null,
                "Messy",
                new Color(0.6f, 0.7f, 0.9f),
                "vengeful child",
                null,
                new List<Trait>
                {
                    new Trait(TraitDefOf.PsychicSensitivity, 2),
                    new Trait(TraitDefOf.Nerves, -2),
                    new Trait(TraitDef.Named("Neurotic"), 1)
                },
                new List<Skill>
                {
                    new Skill(SkillDefOf.Melee, Passion.Major, 6),
                    new Skill(SkillDefOf.Plants, Passion.Minor, 3),
                    new Skill(SkillDefOf.Animals, Passion.Minor, 3),
                    new Skill(SkillDefOf.Artistic, Passion.Major, 6)
                },
                6
            );
        }
    }
}
