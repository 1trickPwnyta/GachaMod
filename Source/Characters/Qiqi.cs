using RimWorld;
using System.Collections.Generic;
using UnityEngine;
using Verse;

namespace GachaMod.Characters
{
    public class Qiqi : Character
    {
        public override Pawn Make()
        {
            return GrantFulfiller.FulfillCharacter
            (
                "Qiqi",
                "Bubu",
                "Pharmacist",
                15f,
                Gender.Female,
                0f,
                null,
                null,
                "Bob",
                new Color(0.9f, 0.85f, 1f),
                "shunned girl",
                null,
                new List<Trait>
                {
                    new Trait(TraitDef.Named("Immunity"), 1),
                    new Trait(TraitDefOf.CreepyBreathing),
                    new Trait(TraitDefOf.PsychicSensitivity, 1)
                },
                new List<Skill>
                {
                    new Skill(SkillDefOf.Melee, Passion.Major, 12),
                    new Skill(SkillDefOf.Plants, Passion.Major, 11),
                    new Skill(SkillDefOf.Animals, Passion.Minor, 6),
                    new Skill(SkillDefOf.Medicine, Passion.Major, 12)
                },
                -1
            );
        }
    }
}
