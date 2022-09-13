using RimWorld;
using System.Collections.Generic;
using UnityEngine;
using Verse;

namespace GachaMod.Characters
{
    public class Bennett : Character
    {
        public override Pawn Make()
        {
            return GrantFulfiller.FulfillCharacter
            (
                "Bennett",
                "Adventure",
                "Adventurer",
                17f,
                Gender.Male,
                0f,
                null,
                null,
                "Messy",
                new Color(0.9f, 0.8f, 0.7f),
                "abandoned orphan",
                null,
                new List<Trait>
                {
                    new Trait(TraitDefOf.NaturalMood, -1),
                    new Trait(TraitDefOf.SpeedOffset, 2),
                    new Trait(TraitDefOf.Wimp)
                },
                new List<Skill>
                {
                    new Skill(SkillDefOf.Melee, Passion.Major, 6),
                    new Skill(SkillDefOf.Cooking, Passion.Minor, 3),
                    new Skill(SkillDefOf.Animals, Passion.Minor, 3),
                    new Skill(SkillDefOf.Medicine, Passion.Major, 5)
                },
                6
            );
        }
    }
}
